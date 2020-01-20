using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Type_Speed
{
    public partial class About_Page : UserControl
    {
        public About_Page()
        {
            InitializeComponent();
        }

        private void About_Page_Load(object sender, EventArgs e)
        {
            
        }

        //This is the website link of the software
        private void Source_code_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/");
        }
    }
}
