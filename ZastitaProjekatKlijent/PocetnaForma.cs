using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZastitaProjekatKlijent
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {

            InitializeComponent();
            
        }


        private void rc4Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC4Forma rc4Forma = new RC4Forma(this);
            rc4Forma.Show();

        }

        private void enigmaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnigmaForma enigmaForma = new EnigmaForma(this);
            enigmaForma.Show();
        }

        private void teaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TEAForma teaForma = new TEAForma(this);
            teaForma.Show();

        }

        private void cbcButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CBCForma cbcForma = new CBCForma(this);
            cbcForma.Show();
        }

        private void crcBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRCTestForm crcForma = new CRCTestForm(this);
            crcForma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC4_Parallel rc4Forma = new RC4_Parallel(this);
            rc4Forma.Show();

        }
    }
}
