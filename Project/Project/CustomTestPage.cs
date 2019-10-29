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
    public partial class CustomTestPage : UserControl
    {
        //Variables
        int time_limit, seconds=0, mistype=0;


        public CustomTestPage()
        {
            InitializeComponent();
        }

        private void CustomTestPage_Load(object sender, EventArgs e)
        {

        }

        //This triggers what will happen if the start button is pressed
        private void StartTest_Click(object sender, EventArgs e)
        {

            if (TimeSet.Text != "" && ParagraphPaste.Text != "" && TimeSet.Text.All(char.IsDigit))
            {
                if (int.Parse(TimeSet.Text) > 0)
                {
                    CTpanel.Visible = true;
                    SidePanel.Visible = true;
                    ParagraphBox.Text = ParagraphPaste.Text;
                    time_limit = int.Parse(TimeSet.Text);
                    timer1.Start();
                }
            }

        }

        //Back button for going back to home page
        private void Back1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Back button for going back to Custom test page
        private void Back2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            seconds = 0;
            TimeLB.Text = "000 s";
            WPMLB.Text = "0 wpm";
            MistypeLB.Text = "0";
            CharactersTypedLB.Text = "0";

            InputBox.Text = null;
            CTpanel.Visible = false;
            SidePanel.Visible = false;
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
                float words_count = InputBox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
                float wpm = words_count / ((float)seconds / 60);

                WPMLB.Text = wpm.ToString("0.##") + " wpm";

            }
            Mistype_Count();

            if (seconds == time_limit)
            {
                timer1.Stop();
            }
        }

        //This is used for keeping track of number of characters typed and changes the Paragraph box text color depending on the character matching
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            CharactersTypedLB.Text = InputBox.Text.Length.ToString();

            if (InputBox.TextLength == 0)
            {
                ParagraphBox.SelectAll();
                ParagraphBox.SelectionBackColor = Color.Transparent;
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

        private void ParagraphPaste_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeSet_TextChanged(object sender, EventArgs e)
        {

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
            {
                ParagraphBox.SelectionBackColor = Color.SkyBlue;
            }
            else if (color == "Red")
            {
                ParagraphBox.SelectionBackColor = Color.Red;
            }

            ParagraphBox.Select(InputBox.TextLength, ParagraphBox.TextLength);
            ParagraphBox.SelectionBackColor = Color.Transparent;

            return;
        }

    }
}
