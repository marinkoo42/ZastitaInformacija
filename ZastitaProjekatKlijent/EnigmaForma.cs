using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZastitaProjekatKlijent.ServiceReference;
using static System.Net.Mime.MediaTypeNames;

namespace ZastitaProjekatKlijent
{
    public partial class EnigmaForma : Form
    {
        Form _parent;
        ServiceZIClient proxy;
        string fileName;
        public EnigmaForma(Form parent)
        {
            _parent = parent;
            proxy = new ServiceZIClient();
            InitializeComponent();

            encryptRadio.Checked = true;

            rotor1Cbx.SelectedIndex= 0;
            rotor2Cbx.SelectedIndex= 0;
            rotor3Cbx.SelectedIndex= 0;

            reflectorCbx.SelectedIndex= 0;
            
        }

        private string ucitajIzFajla(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        private void upisiUFajl(string fileName, string data)
        {
            File.WriteAllText(fileName, data);
        }

        private void EnigmaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (fileName == null || fileName == "")
            {
                MessageBox.Show("Izaberite fajl!");
                return;
            }


            Match match = Regex.Match(enigmaKeyTbx.Text, "^[A-Z]{3}$");
            if (!match.Success) {
                MessageBox.Show("Nevalidan kljuc! Mora biti u formi AAA ");
                return;
            }

            var kljuc = enigmaKeyTbx.Text;

            var r1 = rotor1Cbx.SelectedItem.ToString();
            var r2 = rotor2Cbx.SelectedItem.ToString();
            var r3 = rotor3Cbx.SelectedItem.ToString();

            var ring1 = ringVal1.Value;
            var ring2 = ringVal2.Value;
            var ring3 = ringVal3.Value;

            var ringovi = "" + ring1+ring2+ ring3;

            var reflektor = reflectorCbx.SelectedItem.ToString();

            List<string> plugboardParovi = new List<string>();
            foreach(Object item in plugboardLbx.Items)
            {
                plugboardParovi.Add(item.ToString());
            }




            //smatram da su podaci tekstualnog tipa bez razmaka, tabova i novih linija!!!!
            string podaci = ucitajIzFajla(fileName);
            podaci = podaci.ToUpper();



            var directory = Path.GetDirectoryName(fileName);
            var fileNoExt = Path.GetFileNameWithoutExtension(fileName);
            var ext = Path.GetExtension(fileName);

            if (encryptRadio.Checked)
            {

                var encryptedData = proxy.EnkriptujENIGMA(podaci, ringovi, kljuc, reflektor, r1, r2, r3, plugboardParovi.ToArray());
                var newFileName = directory + "\\" + fileNoExt + "Encrypted_ENIGMA" + ext;
                upisiUFajl(newFileName, encryptedData);

            }
            else
            {
                var encryptedData = proxy.DekriptujENIGMA(podaci, ringovi, kljuc, reflektor, r1, r2, r3, plugboardParovi.ToArray());

                fileNoExt = fileNoExt.Replace("Encrypted_ENIGMA", "Decrypted_ENIGMA");
                var newFileName = directory + "\\" + fileNoExt + ext;
                upisiUFajl(newFileName, encryptedData);

            }

        }

        private void plugboardAddBtn_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(plugboardTbx.Text, "^[A-Z]{2}$");
            if (!match.Success)
            {
                MessageBox.Show("Nevalidan plug! Mora biti u formi AA ");
                return;
            }
            if (!plugboardLbx.Items.Contains(plugboardTbx.Text))
            {
                plugboardLbx.Items.Add(plugboardTbx.Text);
            }

        }

        private void plugboardRemoveBtn_Click(object sender, EventArgs e)
        {
            plugboardLbx.Items.Remove(plugboardLbx.SelectedItem);
            
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileName = fileDialog.FileName;
            fileNameTbx.Text = fileName;
        }
    }
}
