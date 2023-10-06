using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZastitaProjekatKlijent.ServiceReference;
using System.Configuration;

namespace ZastitaProjekatKlijent
{
    public partial class RC4Forma : Form
    {
        Form _parent;
        ServiceZIClient proxy;

        string fileName;
        public RC4Forma(Form parent)
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
             File.WriteAllBytes(fileName,data);
        }

        private void RC4Forma_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileName = fileDialog.FileName;
            fileNameTbx.Text = fileName;
            //Path.GetDirectoryName(fileName);
        }

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();

          
        }

        
        // implementiran deo za ucitavanje .bmp slike
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
            

            byte[] podaci = ucitajIzFajla(fileName);

            
            var ext = Path.GetExtension(fileName);
            byte[] bmpHeader = Array.Empty<Byte>();
            if (ext == ".bmp")
            {
                bmpHeader = podaci.Take(54).ToArray();
                podaci = podaci.Skip(54).ToArray();
            }
            var kljuc = System.Text.Encoding.Unicode.GetBytes(keyTbx.Text);
            var directory = Path.GetDirectoryName(fileName);
            var fileNoExt = Path.GetFileNameWithoutExtension(fileName);

            if (encryptRadio.Checked)
            {
                
                var encryptedData = proxy.EnkriptujRC4(podaci,kljuc);
                var newFileName = directory + "\\" + fileNoExt + "Encrypted_RC4"+ext;
                if (ext == ".bmp")
                {
                    bmpHeader = bmpHeader.Concat(encryptedData).ToArray();
                    upisiUFajl(newFileName, bmpHeader);
                }
                else
                {
                    upisiUFajl(newFileName, encryptedData);

                }

            }
            else
            {
                var encryptedData = proxy.DekriptujRC4(podaci, kljuc);
                fileNoExt = fileNoExt.Replace("Encrypted_RC4", "Decrypted_RC4");
                var newFileName = directory + "\\" + fileNoExt + ext;
                if (ext == ".bmp")
                {
                    bmpHeader = bmpHeader.Concat(encryptedData).ToArray();
                    upisiUFajl(newFileName, bmpHeader);
                }
                else
                {
                    upisiUFajl(newFileName, encryptedData);

                }


            }
            
        }

    }
}
