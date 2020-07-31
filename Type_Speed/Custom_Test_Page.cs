using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Type_Speed
{
    public partial class Custom_Test_Page : UserControl
    {

        public Custom_Test_Page()
        {
            InitializeComponent();
        }

        private void Custom_Test_Page_Load(object sender, EventArgs e)
        {
            test_Page1.Hide();
        }

        //This is the back button
        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParagraphPasteBox.Text = null;
            TimeSet.Text = null;
        }

        //This triggers what will happen if the start button is pressed
        private void Start_Test_Click(object sender, EventArgs e)
        {
            if (TimeSet.Text == "" || ParagraphPasteBox.Text == "")
                MessageBox.Show("The paragraph box or timer box or both are empty");

            else if (ParagraphPasteBox.TextLength < 30)
                MessageBox.Show("The paragraph is too small. Required minimum character length is 30");

            else if (TimeSet.Text != "" && ParagraphPasteBox.Text != "" && ParagraphPasteBox.TextLength >= 30)
            {
                if (TimeSet.Text.All(char.IsDigit) && int.Parse(TimeSet.Text) > 0)
                {
                    test_Page1.Show();
                    test_Page1.BringToFront();
                    test_Page1.Focus();
                    test_Page1.ParagraphBox.Text = ParagraphPasteBox.Text;
                    test_Page1.time_limit = int.Parse(TimeSet.Text);
                    test_Page1.TimeLB.Text = test_Page1.time_limit.ToString() + " s";
                }
                else
                    MessageBox.Show("The time limit should be a number and greater than 0");
            }
        }

        //This is the load button which loads text file to the ParagraphPasteBox
        private void Load_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Title = "Open the text file";
            load.Filter = "Text file(*.txt)|*.txt";
            if (load.ShowDialog() == DialogResult.OK)
            {
                ParagraphPasteBox.Text = File.ReadAllText(load.FileName, Encoding.ASCII);
            }
        }

        //This is the save button which saves text file from the ParagraphPasteBox
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (ParagraphPasteBox.TextLength == 0)
                MessageBox.Show("The text box is empty.");

            else if (ParagraphPasteBox.TextLength < 30)
                MessageBox.Show("The paragraph is too small. Required minimum characters length is 30");

            else if (ParagraphPasteBox.TextLength >= 30)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Choose a location where you want to save";
                save.Filter = "Text file(*.txt)|*.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(save.FileName, ParagraphPasteBox.Text);
                }
            }
        }
    }
}
