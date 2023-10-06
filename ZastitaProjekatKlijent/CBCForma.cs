using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZastitaProjekatKlijent.ServiceReference;

namespace ZastitaProjekatKlijent
{
    public partial class CBCForma : Form
    {

        Form _parent;
        ServiceZIClient proxy;

        string fileName;

        public CBCForma(Form parent)
        {
            _parent = parent;
            proxy = new ServiceZIClient();
            
            InitializeComponent();
            encryptRadio.Checked = true;
        }

        private byte[] ucitajIzFajla(string fileName)
        {

            return File.ReadAllBytes(fileName);
        }

        private void upisiUFajl(string fileName, byte[] data)
        {
            File.WriteAllBytes(fileName, data);
        }

        private void CBCForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileName = fileDialog.FileName;
            fileNameTbx.Text = fileName;

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (fileName == null || fileName == "")
            {
                MessageBox.Show("Izaberite fajl!");
                return;
            }
            if (keyTbx.Text == null || keyTbx.Text == "")
            {
                MessageBox.Show("Unesite kljuc!");
                return;
            }

            if (IVTbx.Text == null || IVTbx.Text == "")
            {
                MessageBox.Show("Unesite inicijalizacioni vektor!");
                return;
            }

            byte[] kljuc = Encoding.UTF8.GetBytes(keyTbx.Text);
            if (kljuc.Length < 16)
            {
                MessageBox.Show("Uneti kljuc nije pogodan za TEA!");
                return;
            }

            byte[] podaci = ucitajIzFajla(fileName);
            if (podaci.Length % 8 != 0)
            {
                MessageBox.Show("Uneti podaci nisu pogodni za TEA!");
                return;
            }

            byte[] IV = Encoding.UTF8.GetBytes(IVTbx.Text);
            if (IV.Length < 8)
            {
                MessageBox.Show("Uneti inicijalizacioni vektor nije pogodan za TEA!");
                return;
            }
            
            var directory = Path.GetDirectoryName(fileName);
            var fileNoExt = Path.GetFileNameWithoutExtension(fileName);
            var ext = Path.GetExtension(fileName);

            if (encryptRadio.Checked)
            {
                
                var encryptedData = proxy.EnkriptujTEA_CBC_Mode(podaci, kljuc, IV);
                var newFileName = directory + "\\" + fileNoExt + "Encrypted_TEA_CBC" + ext;
                upisiUFajl(newFileName, encryptedData);

            }
            else
            {
                var encryptedData = proxy.DekriptujTEA_CBC_Mode(podaci, kljuc, IV);
                fileNoExt = fileNoExt.Replace("Encrypted_TEA_CBC", "Decrypted_TEA_CBC");
                var newFileName = directory + "\\" + fileNoExt + ext;
                upisiUFajl(newFileName, encryptedData);

            }


        }
    }
}
