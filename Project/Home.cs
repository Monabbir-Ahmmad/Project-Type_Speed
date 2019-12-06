using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //This disables the arrow keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) || (keyData == Keys.Up) || (keyData == Keys.Down))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        //This is for moving the window with mouse
        private void Mouse_Down(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

                if (WindowState == FormWindowState.Normal)
                    MaximizeToNormal.Visible = false;
            }
        }

        //This is a function that hide pages
        private void Hide_All()
        {
            faqPage1.Visible = false;
            aboutPage1.Visible = false;
            tipsPage1.Visible = false;
            normalTestPage1.Visible = false;
            customTestPage1.Visible = false;
            return;
        }

        //This is the exit button
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is the maximize window button
        private void Maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MaximizeToNormal.Visible = true;
        }

        //This is the maximize to normal window button
        private void MaximizeToNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            MaximizeToNormal.Visible = false;
        }

        //This is the minimize window button
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void NormalTest_Click(object sender, EventArgs e)
        {
            Hide_All();
            normalTestPage1.Visible = true;
            normalTestPage1.BringToFront();
        }

        private void CustomTest_Click(object sender, EventArgs e)
        {
            Hide_All();
            customTestPage1.Visible = true;
            customTestPage1.BringToFront();
        }

        private void FAQ_Click(object sender, EventArgs e)
        {
            Hide_All();
            faqPage1.Visible = true;
        }

        private void About_Click(object sender, EventArgs e)
        {
            Hide_All();
            aboutPage1.Visible = true;
        }

        private void Tips_Click(object sender, EventArgs e)
        {
            Hide_All();
            tipsPage1.Visible = true;
        }

    }
}
