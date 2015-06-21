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
    public partial class OmCodingPirates : Form
    {
        public OmCodingPirates()
        {
            InitializeComponent();
        }

        private void linkforum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("https://forum.codingpirates.dk/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink(string link)
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkhome.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start(link);
        }

        private void linkhome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("http://codingpirates.dk/");
            }
            catch
            {
                MessageBox.Show("Unable to open link taht was clicked.");
            }
        }
    }
}
