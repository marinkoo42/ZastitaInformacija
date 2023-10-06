using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZastitaProjekatKlijent.ServiceReference;

namespace ZastitaProjekatKlijent
{
    public partial class TEAForma : Form
    {

        Form _parent;
        ServiceZIClient proxy;

        string fileName;

        public TEAForma(Form parent)
        {
            _parent = parent;
            proxy = new ServiceZIClient();
            InitializeComponent();

            encryptRadio.Checked = true;
        }

        private byte[] ucitajIzFajla(string fileName)
        {
            var text = File.ReadAllText(fileName,Encoding.UTF8);
            return Encoding.UTF8.GetBytes(text);
        }

        private void upisiUFajl(string fileName, byte[] data)
        {
            var bts = Encoding.UTF8.GetString(data);
            File.WriteAllText(fileName, bts);
        }

        private void TEAForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
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


            var directory = Path.GetDirectoryName(fileName);
            var fileNoExt = Path.GetFileNameWithoutExtension(fileName);
            var ext = Path.GetExtension(fileName);

            if (encryptRadio.Checked)
            {

                var encryptedData = proxy.EnkriptujTEA(podaci, kljuc);
                var newFileName = directory + "\\" + fileNoExt + "Encrypted_TEA" + ext;
                upisiUFajl(newFileName, encryptedData);

            }
            else
            {
                var encryptedData = proxy.DekriptujTEA(podaci, kljuc);
                fileNoExt = fileNoExt.Replace("Encrypted_TEA", "Decrypted_TEA");
                var newFileName = directory + "\\" + fileNoExt + ext;
                upisiUFajl(newFileName, encryptedData);

            }


        }

        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileName = fileDialog.FileName;
            fileNameTbx.Text = fileName;

        }
    }
}
