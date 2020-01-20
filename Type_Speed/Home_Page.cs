using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Type_Speed
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            Hide_All();
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
                {
                    Maximize.Text = "☐";
                }
            }
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


        //This is a function that hide pages
        private void Hide_All()
        {
            test_Page1.Hide();
            custom_Test_Page1.Hide();
            faQ_Page1.Hide();
            tips_Page1.Hide();
            about_Page1.Hide();
        }

        //This is the exit button
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is the maximize window button
        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
                Maximize.Text = "❐";
            }

           else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Maximize.Text = "☐";
            }
        }

        //This is the minimize window button
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void NormalTest_Click(object sender, EventArgs e)
        {
            Hide_All();
            test_Page1.Show();
            test_Page1.BringToFront();
            test_Page1.Focus();

            Random_Test();  
        }

        private void CustomTest_Click(object sender, EventArgs e)
        {
            Hide_All();
            custom_Test_Page1.Show();
            custom_Test_Page1.BringToFront();
            custom_Test_Page1.Focus();
        }

        private void FAQ_Click(object sender, EventArgs e)
        {
            Hide_All();
            faQ_Page1.Show();
            faQ_Page1.BringToFront();
            faQ_Page1.Focus();
        }

        private void Tips_Click(object sender, EventArgs e)
        {
            Hide_All();
            tips_Page1.Show();
            tips_Page1.BringToFront();
            tips_Page1.Focus();
        }

        private void About_Click(object sender, EventArgs e)
        {
            Hide_All();
            about_Page1.Show();
            about_Page1.BringToFront();
            about_Page1.Focus();
        }

        //This sets paragraph and time limit randomly
        private void Random_Test()
        {
            Random rnd = new Random();
            int genRand = rnd.Next(1, 21);

            if (genRand == 1)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_1.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 155;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 2)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_2.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 75;
                test_Page1.TimeLB.Text = "0" + test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 3)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_3.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 115;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 4)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_4.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 100;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 5)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_5.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 130;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 6)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_6.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 105;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 7)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_7.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 195;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 8)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_8.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 150;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 9)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_9.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 140;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 10)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_10.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 165;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 11)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_11.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 120;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 12)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_12.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 33;
                test_Page1.TimeLB.Text = "0" + test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 13)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_13.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 38;
                test_Page1.TimeLB.Text = "0" + test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 14)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_14.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 115;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 15)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_15.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 168;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 16)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_16.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 185;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 17)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_17.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 105;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 18)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_18.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 190;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 19)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_19.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 155;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }
            else if (genRand == 20)
            {
                StreamReader Paragraph = new StreamReader(Application.StartupPath + "\\Paragraph\\" + "Paragraph_20.txt");
                test_Page1.ParagraphBox.Text = Paragraph.ReadToEnd();
                Paragraph.Close();
                test_Page1.time_limit = 160;
                test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
            }

        }
    }
}
