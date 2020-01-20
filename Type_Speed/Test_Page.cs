using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Type_Speed
{
    public partial class Test_Page : UserControl
    {
        //Variables
        public int time_limit;
        int seconds = 0, mistype = 0;
        float wpm = 0, words_count = 0;

        public Test_Page()
        {
            InitializeComponent();
        }

        private void Test_Page_Load(object sender, EventArgs e)
        {
            result_Page1.Hide();
        }

        //This is the back button
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            result_Page1.Hide();
            timer1.Stop();
            seconds = 0;
            TimeLB.Text = "000 s";
            WPMLB.Text = "0 wpm";
            MistypeLB.Text = "0";
            CharactersTypedLB.Text = "0";
            InputBox.Enabled = true;
            InputBox.Text = null;
            label5.Visible = true;
        }

        //This disables the control keys
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                e.Handled = true;
            }
        }

        //This triggers the timer when inputbox is clicked and the test starts
        private void InputBoxClick(object sender, EventArgs e)
        {
            InputBox.MaxLength = ParagraphBox.TextLength;
            InputBox.Focus();
            timer1.Start();
            InputBox.SelectionStart = InputBox.TextLength;
            label5.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            InputBoxClick(sender, e);
        }

        //This is used for keeping track of number of characters typed and changes the Paragraph box text color depending on the character matching
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            CharactersTypedLB.Text = InputBox.Text.Length.ToString();

            Mistype_Count();

            if (InputBox.TextLength == ParagraphBox.TextLength)
            {
                InputBox.Enabled = false;
                timer1.Stop();
                Result();
            }

            if (InputBox.TextLength == 0)
            {
                ParagraphBox.SelectAll();
                ParagraphBox.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#F0F0F0");
            }

            else
            {
                int i = InputBox.TextLength - 1;

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

        //This is the timmer and the events related to it
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if ((time_limit - seconds) < 10)
                TimeLB.Text = "00" + (time_limit-seconds).ToString() + " s";
            else if ((time_limit - seconds) < 100)
                TimeLB.Text = "0" + (time_limit - seconds).ToString() + " s";
            else
                TimeLB.Text = (time_limit-seconds).ToString() + " s";



            if (seconds > 0)
            {
                char[] separator = { ' ' };
                words_count = InputBox.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;
                wpm = words_count / ((float)seconds / 60);

                WPMLB.Text = wpm.ToString("0.##") + " wpm";

            }

            if (seconds == time_limit)
            {
                InputBox.Enabled = false;
                timer1.Stop();
                Result();
            }
        }

        //This function calls the result page and passes the values
        private void Result()
        {
            result_Page1.wpm = wpm;
            result_Page1.mistype = mistype;
            result_Page1.characters_typed = float.Parse(CharactersTypedLB.Text);
            result_Page1.Show();
            result_Page1.Result();
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
            ParagraphBox.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#F0F0F0");

            return;
        }
    }
}
