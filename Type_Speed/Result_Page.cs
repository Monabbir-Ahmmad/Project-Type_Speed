using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Type_Speed
{
    public partial class Result_Page : UserControl
    {
        public float wpm, mistype, characters_typed, score, highest_wpm = 0;
        int sec = 0, high_score = 0;
        string high_scorer_name;

        XmlSerializer xs = new XmlSerializer(typeof(List<UserData>));
        List<UserData> ls = new List<UserData>();

        public Result_Page()
        {
            InitializeComponent();
        }

        private void Result_Page_Load(object sender, EventArgs e)
        {
            //This creates user data save directory and file
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Public\Documents\Type Speed");

            if (!directory.Exists)
            {
                directory.Create();

                FileStream file = new FileStream(@"C:\Users\Public\Documents\Type Speed\date.xml", FileMode.Create, FileAccess.Write);
                UserData user = new UserData();

                user.name = "Admin";
                user.high_score = "0";
                user.wpm = "0";

                ls.Add(user);

                xs.Serialize(file, ls);
                file.Close();
                ls.Clear();
            }
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

        //This gets high score and scorer's name from file
        private void Get_Score_From_File()
        {
            //This takes data from a file
            FileStream file = new FileStream(@"C:\Users\Public\Documents\Type Speed\date.xml", FileMode.Open, FileAccess.Read);
            ls = (List<UserData>)xs.Deserialize(file);

            UserData current_high_scorer = ls[0];

            high_scorer_name = current_high_scorer.name;
            high_score = int.Parse(current_high_scorer.high_score);
            highest_wpm = float.Parse(current_high_scorer.wpm);
            file.Close();
            ls.Clear();
        }

        //This is the button saves high score in a file
        private void Save_score_Click(object sender, EventArgs e)
        {
            if (Scorer_Name.TextLength > 0)
            {

                FileStream file = new FileStream(@"C:\Users\Public\Documents\Type Speed\date.xml", FileMode.Create, FileAccess.Write);
                UserData new_best_scorer = new UserData();

                new_best_scorer.name = Scorer_Name.Text;
                new_best_scorer.high_score = score.ToString();
                new_best_scorer.wpm = wpm.ToString();

                ls.Add(new_best_scorer);

                xs.Serialize(file, ls);
                file.Close();
                ls.Clear();

                high_score = (int)score;
                Save_score.Text = "Saved";
            }

            else
                MessageBox.Show("Please enter your name");
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
