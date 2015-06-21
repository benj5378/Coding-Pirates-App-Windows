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

        private void button2_Click(object sender, EventArgs e)
        {
            AfdelingerIRegionHovedstaden afdelingeriregionhovedstaden = new AfdelingerIRegionHovedstaden();
            afdelingeriregionhovedstaden.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AfdelingerIRegionSjælland afdelingeriregionsjælland = new AfdelingerIRegionSjælland();
            afdelingeriregionsjælland.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AfdelingerIRegionSydDanmark afdelingeriregionsyddanmark = new AfdelingerIRegionSydDanmark();
            afdelingeriregionsyddanmark.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AfdelingerIRegionMidtjylland afdelingeriregionmidtjylland = new AfdelingerIRegionMidtjylland();
            afdelingeriregionmidtjylland.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AfdelingerIRegionNordjylland afdelingeriregionmidtjylland = new AfdelingerIRegionNordjylland();
            afdelingeriregionmidtjylland.ShowDialog(this);
        }
    }
}