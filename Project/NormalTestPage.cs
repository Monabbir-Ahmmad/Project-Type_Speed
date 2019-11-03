using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class NormalTestPage : UserControl
    {
        //Variables
        int seconds =0, mistype = 0;


        public NormalTestPage()
        {
            InitializeComponent();
        }

        private void NTPage_Load(object sender, EventArgs e)
        {
            
        }

        //Back button for going back to home page
        private void Back1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Back button for going back to normal test page
        private void Back2_Click(object sender, EventArgs e)
        {   
            timer1.Stop();
            seconds = 0;
            TimeLB.Text = "000 s";
            WPMLB.Text = "0 wpm";
            MistypeLB.Text = "0";
            CharactersTypedLB.Text = "0";
            InputBox.Enabled = true;
            InputBox.Text = null;
            NTpanel.Visible = false;
            SidePanel.Visible = false;
        }
        
        //This is test1 button
        private void Test1_Click(object sender, EventArgs e)
        {
            ParagraphBox.Text = "Test 1 is easy";
            NTpanel.Visible = true;
            SidePanel.Visible = true;
            timer1.Start();
        }

        //This is test2 button
        private void Test2_Click(object sender, EventArgs e)
        {
            ParagraphBox.Text = "Test 2 is easy enough";
            NTpanel.Visible = true;
            SidePanel.Visible = true;
            timer1.Start();
        }

        //This is test2 button
        private void Test3_Click(object sender, EventArgs e)
        {
            ParagraphBox.Text = "Test 3 is average";
            NTpanel.Visible = true;
            SidePanel.Visible = true;
            timer1.Start();
        }

        //This is test4 button
        private void Test4_Click_1(object sender, EventArgs e)
        {
            ParagraphBox.Text = "Test 4 is hard";
            NTpanel.Visible = true;
            SidePanel.Visible = true;
            timer1.Start();
        }

        //This is test5 button
        private void Test5_Click(object sender, EventArgs e)
        {
            ParagraphBox.Text = "Test 5 is very hard";
            NTpanel.Visible = true;
            SidePanel.Visible = true;
            timer1.Start();
        }

        //This is the timmer and the events related to it
        private void timer1_Tick(object sender, EventArgs e)
        {
                seconds++;

            if (seconds < 10)
                TimeLB.Text = "00" + seconds.ToString() + " s";
            else if (seconds < 100)
                TimeLB.Text = "0" + seconds.ToString() + " s";
            else
                TimeLB.Text = seconds.ToString() + " s";



            if (seconds > 0)
            {
                char[] separator = { ' ' };
                float words_count= InputBox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
                float wpm= words_count / ((float)seconds /60);

                WPMLB.Text = wpm.ToString("0.##") + " wpm";

            }

        }

        //This is used for keeping track of number of characters typed and changes the Paragraph box text color depending on the character matching
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            CharactersTypedLB.Text = InputBox.Text.Length.ToString();

            if (InputBox.TextLength == ParagraphBox.TextLength)
            {
                InputBox.Enabled = false;
                timer1.Stop();
            }
            Mistype_Count();

            if (InputBox.TextLength == 0)
            {
                ParagraphBox.SelectAll();
                ParagraphBox.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#F0F0F0");
            }
            else
            {
                for (int i = 0; i < InputBox.TextLength; i++)
                {
                    if (InputBox.Text[i].ToString() != ParagraphBox.Text[i].ToString())
                    {
                        ParagraphBox_Color_Change(i, "Red");
                    }
                    else if (InputBox.Text[i].ToString() == ParagraphBox.Text[i].ToString())
                    {
                        ParagraphBox_Color_Change(i, "Blue");
                    }
                }
            }

        }

        //This stops the user from using the mouse inside the Input box
        private void InputBoxClick(object sender, EventArgs e)
        {
            InputBox.SelectionStart = InputBox.TextLength;
        }

        //This stops the user from using spacific keys inside the Input box
        private void key_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
            }

        }

        //Function for counting mistypes
        private void Mistype_Count()
        {
            mistype = 0;
            if (InputBox.TextLength == 0)
            {
                MistypeLB.Text = "0";
            }
            else
            {
                for (int i = 0; i < InputBox.TextLength; i++)
                {
                    if (InputBox.Text[i].ToString() != ParagraphBox.Text[i].ToString())
                    {
                        mistype++;
                    }
                }

                MistypeLB.Text = mistype.ToString();
                return;
            }
        }

        //Function for Paragraph box text color changing
        private void ParagraphBox_Color_Change(int start, string color)
        {
            ParagraphBox.Select(start, 1);
            if (color == "Blue")
                ParagraphBox.SelectionBackColor = Color.SkyBlue;
            else if (color == "Red")
                ParagraphBox.SelectionBackColor = Color.Red;

            ParagraphBox.Select(InputBox.TextLength, ParagraphBox.TextLength);
            ParagraphBox.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#F0F0F0");
            return;
        }
    }
}
