using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication4
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Afdelingerb_Click(object sender, EventArgs e)
        {
            Afdelinger afdelinger = new Afdelinger();
            afdelinger.ShowDialog(this);
        }

        private void Frivilligeb_Click(object sender, EventArgs e)
        {

        }

        private void Om_Coding_Piratesb_Click(object sender, EventArgs e)
        {
            OmCodingPirates omcodingpirates = new OmCodingPirates();
            omcodingpirates.ShowDialog(this);
        }

        private void Creditsb_Click(object sender, EventArgs e)
        {

        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.ShowDialog(this);
            //global bool close = true;
            MessageBox.Show("Closing");
            Thread.Sleep(1000);
            Application.Exit();
        }
    }
}
