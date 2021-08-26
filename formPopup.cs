using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace money_calc
{
    public partial class formPopup : Form
    {
        public formPopup()
        {
            InitializeComponent();
        }

        private void dennethnl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dennethnl.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.denneth.nl");
        }

        private void api_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            api.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.goldapi.io/");
        }
    }
}
