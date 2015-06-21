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
    public partial class AfdelingerIRegionHovedstaden : Form
    {
        public AfdelingerIRegionHovedstaden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfdelingenHellerup afdelingenhellerup = new AfdelingenHellerup();
            afdelingenhellerup.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
