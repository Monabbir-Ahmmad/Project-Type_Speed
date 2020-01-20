using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Type_Speed
{
    public partial class Result_Page : UserControl
    {
        public float wpm, mistype, characters_typed, score, highest_wpm=0;
        int sec = 0, high_score=0;
        string high_scorer_name;

        public Result_Page()
        {
            InitializeComponent();
        }

        private void Result_Page_Load(object sender, EventArgs e)
        {
            
        }

        //This recives different values form test page
        public void Result()
        {
            this.Focus();
            //This resets everything
            score = 0;
            panel1.Visible = false;
            label2.Visible = false;
            ScoreLB.Text = null;
            Save_score.Text = "Save";
            Current_High_Score.Text = "Current High Score:";
            Scorer_Name.Text = null;
            Get_Score_From_File();

            //This calculates the score
            if (characters_typed == 0)
                characters_typed = 1;

            float accuracy = (characters_typed - mistype) / characters_typed;
            score = wpm * accuracy;
            score = (int)score;
            animation_timer1.Start();
        }

        //This gets high score and scorer's name from text file
        private void Get_Score_From_File()
        {
            //This takes current high score from a text file
            StreamReader HighScorer_Name = new StreamReader(Application.StartupPath + "\\Saved_data\\" + "High Scorer Name.txt");
            high_scorer_name = HighScorer_Name.ReadToEnd();
            HighScorer_Name.Close();

            //This takes current high scorer name from a text file
            StreamReader High_Score = new StreamReader(Application.StartupPath + "\\Saved_data\\" + "High Score.txt");
            high_score = int.Parse(High_Score.ReadToEnd());
            High_Score.Close();

            //This takes current highest wpm from a text file
            StreamReader Highest_WPM = new StreamReader(Application.StartupPath + "\\Saved_data\\" + "Highest WPM.txt");
            highest_wpm = float.Parse(Highest_WPM.ReadToEnd());
            Highest_WPM.Close();
        }

        //This is the button for saving high score and scorer's name to text file
        private void Save_score_Click(object sender, EventArgs e)
        {
            if (Scorer_Name.TextLength > 0)
            {
                //This saves high scorer name
                StreamWriter HighScorer_Name = new StreamWriter(Application.StartupPath + "\\Saved_data\\" + "High Scorer Name.txt");
                HighScorer_Name.WriteLine(Scorer_Name.Text);
                HighScorer_Name.Close();

                ////This saves high score
                StreamWriter High_Score = new StreamWriter(Application.StartupPath + "\\Saved_data\\" + "High Score.txt");
                High_Score.WriteLine(score.ToString());
                High_Score.Close();

                //This saves highest wpm
                StreamWriter Highest_WPM = new StreamWriter(Application.StartupPath + "\\Saved_data\\" + "Highest WPM.txt");
                Highest_WPM.WriteLine(wpm.ToString());
                Highest_WPM.Close();

                high_score = (int)score;
                Save_score.Text = "Saved";
            }

            else
                MessageBox.Show("Please enter your nickname");
        }

        //This is for different animations and showing scores
        private void animation_timer1_Tick(object sender, EventArgs e)
        {
            sec++;

            if (sec > 100 && sec < 250)
            {
                //This creates a randomness animation
                Random rnd = new Random();
                int genRand = rnd.Next(100);
                ScoreLB.Text = genRand.ToString();

            }

            if (sec > 250)
            {
                //This shows final score and current high score
                ScoreLB.Text = score.ToString();
                Current_High_Score.Text = "Current High Score: " + high_score.ToString() + " (" + highest_wpm.ToString("0.##") + "wpm)" + " by " + high_scorer_name;

                if (score > high_score)
                {
                    if (sec == 400)
                    {
                        //This shows the new high score and save option
                        label2.Visible = true;
                        animation_timer1.Stop();
                        sec = 0;
                        panel1.Visible = true;
                    }
                }

                else
                {
                    animation_timer1.Stop();
                    sec = 0;
                }
            }
        }
    }
}
