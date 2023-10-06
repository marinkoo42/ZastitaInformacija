using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZastitaProjekatKlijent.ServiceReference;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ZastitaProjekatKlijent
{
    public partial class RC4_Parallel : Form
    {

        Form _parent;
        ServiceZIClient proxy;

        string fileName;
        public RC4_Parallel(Form parent)
        {
            _parent = parent;
            proxy= new ServiceZIClient();
            InitializeComponent();

            encryptRadio.Checked = true;
        }

   
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }


        //ne proveravam da li je .bmp fajl pri paralelizaciji
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

            byte[] inputBytes = File.ReadAllBytes(fileName);
            var kljuc = System.Text.Encoding.Unicode.GetBytes(keyTbx.Text);

            var ext = Path.GetExtension(fileName);
            var directory = Path.GetDirectoryName(fileName);
            var fileNoExt = Path.GetFileNameWithoutExtension(fileName);
            var newFileName = "";


            int chunkSize = inputBytes.Length / Environment.ProcessorCount;
            byte[][] chunks = Enumerable.Range(0, inputBytes.Length / chunkSize)
                                .Select(i => inputBytes.Skip(i * chunkSize).Take(chunkSize).ToArray())
                                .ToArray();

            CountdownEvent countdownEvent = new CountdownEvent(chunks.Length);


            for (int i = 0; i < chunks.Length; i++)
            {
                int j = i;
                ThreadPool.QueueUserWorkItem(async state =>
                {

                        if (encryptRadio.Checked)
                        {
                            Console.WriteLine(chunks[j]);
                            newFileName = directory + "\\" + fileNoExt + "Encrypted_RC4_Parallel" + ext;
                            chunks[j] = await proxy.EnkriptujRC4Async(chunks[j], kljuc);
                            Console.WriteLine(chunks[j]);

                        }
                        else{
                            fileNoExt = fileNoExt.Replace("Encrypted_RC4_Parallel", "Decrypted_RC4_Parallel");
                            newFileName = directory + "\\" + fileNoExt + ext;
                            chunks[j] = await proxy.DekriptujRC4Async(chunks[j], kljuc);
                        }

                    countdownEvent.Signal();
                });
            }


            countdownEvent.Wait();

            byte[] outputBytes = chunks.SelectMany(b => b).ToArray();
            File.WriteAllBytes(newFileName, outputBytes);

        }

        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileName = fileDialog.FileName;
            fileNameTbx.Text = fileName;

        }

        private void RC4_Parallel_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
        }
    }
}
