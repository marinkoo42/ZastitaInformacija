using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZastitaProjekatKlijent.ServiceReference;

namespace ZastitaProjekatKlijent
{
    public partial class CRCTestForm : Form
    {
        ServiceZIClient proxy;
        string file1Name, file2Name;
        Form _parent;

        public CRCTestForm(Form parent)
        {
            proxy = new ServiceZIClient();
            InitializeComponent();
            resultLbl.Text = "";
            _parent = parent;   
        }

        private void file1Btn_Click(object sender, EventArgs e)
        {
            file1Dialog.ShowDialog();
        }

        private void file2Btn_Click(object sender, EventArgs e)
        {
            file2Dialog.ShowDialog();
        }

        private void file2Dialog_FileOk(object sender, CancelEventArgs e)
        {
            file2Name = file2Dialog.FileName;
            fileName2Tbx.Text = file2Name;

        }


        private void file1Dialog_FileOk(object sender, CancelEventArgs e)
        {
            file1Name = file1Dialog.FileName;
            fileName1Tbx.Text = file1Name;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (file1Name == null || file1Name == "")
            {
                MessageBox.Show("Izaberite prvi fajl!");
                return;
            }

            if (file2Name == null || file2Name == "")
            {
                MessageBox.Show("Izaberite drugi fajl!");
                return;
            }

            var file1bytes = ucitajIzFajla(file1Name);
            var file2bytes = ucitajIzFajla(file2Name);

            uint file1check = proxy.Crc32(file1bytes);
            uint file2check = proxy.Crc32(file2bytes);

            if(file1check == file2check)
            {
                resultLbl.Text = "Fajlovi se podudaraju!";
            }
            else
            {
                resultLbl.Text = "Fajlovi se ne podudaraju!";

            }

        }

        private void CRCTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }

        private byte[] ucitajIzFajla(string fileName)
        {

            return File.ReadAllBytes(fileName);
        }


    }
}
