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
    public partial class AfdelingerISjælland : Form
    {
        public AfdelingerISjælland()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfdelingerIRegionHovedstaden afdelingeriregionhovedstaden = new AfdelingerIRegionHovedstaden();
            afdelingeriregionhovedstaden.ShowDialog(this);
        }
    }
}
