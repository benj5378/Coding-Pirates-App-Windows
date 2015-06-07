using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Afdelinger : Form
    {
        public Afdelinger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfdelingerISjælland afdelingerisjælland = new AfdelingerISjælland();
            afdelingerisjælland.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AfdelingerIFyn afdelingerifyn = new AfdelingerIFyn();
            afdelingerifyn.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AfdelingerIJylland afdelingerijylland = new AfdelingerIJylland();
            afdelingerijylland.ShowDialog(this);
        }
    }
}
