namespace Type_Speed
{
    partial class Result_Page
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animation_timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_score = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Scorer_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Current_High_Score = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animation_timer1
            // 
            this.animation_timer1.Interval = 10;
            this.animation_timer1.Tick += new System.EventHandler(this.animation_timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Save_score);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Scorer_Name);
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 160);
            this.panel1.TabIndex = 15;
            // 
            // Save_score
            // 
            this.Save_score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Save_score.FlatAppearance.BorderSize = 0;
            this.Save_score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Save_score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Save_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_score.ForeColor = System.Drawing.Color.White;
            this.Save_score.Location = new System.Drawing.Point(429, 80);
            this.Save_score.Name = "Save_score";
            this.Save_score.Size = new System.Drawing.Size(85, 47);
            this.Save_score.TabIndex = 10;
            this.Save_score.TabStop = false;
            this.Save_score.Text = "Save";
            this.Save_score.UseVisualStyleBackColor = false;
            this.Save_score.Click += new System.EventHandler(this.Save_score_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(344, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Your Nickname";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scorer_Name
            // 
            this.Scorer_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Scorer_Name.BackColor = System.Drawing.Color.Silver;
            this.Scorer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scorer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorer_Name.Location = new System.Drawing.Point(292, 34);
            this.Scorer_Name.MaxLength = 15;
            this.Scorer_Name.Name = "Scorer_Name";
            this.Scorer_Name.Size = new System.Drawing.Size(361, 40);
            this.Scorer_Name.TabIndex = 8;
            this.Scorer_Name.TabStop = false;
            this.Scorer_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(204, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 66);
            this.label2.TabIndex = 14;
            this.label2.Text = "New High Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLB
            // 
            this.ScoreLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreLB.Font = new System.Drawing.Font("Algerian", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLB.ForeColor = System.Drawing.Color.Black;
            this.ScoreLB.Location = new System.Drawing.Point(218, 144);
            this.ScoreLB.Name = "ScoreLB";
            this.ScoreLB.Size = new System.Drawing.Size(509, 105);
            this.ScoreLB.TabIndex = 12;
            this.ScoreLB.Text = "00";
            this.ScoreLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 86);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Current_High_Score
            // 
            this.Current_High_Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Current_High_Score.AutoSize = true;
            this.Current_High_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Current_High_Score.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_High_Score.Location = new System.Drawing.Point(116, 309);
            this.Current_High_Score.Name = "Current_High_Score";
            this.Current_High_Score.Size = new System.Drawing.Size(276, 24);
            this.Current_High_Score.TabIndex = 16;
            this.Current_High_Score.Text = "Current High Score:";
            // 
            // Result_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Current_High_Score);
            this.Name = "Result_Page";
            this.Size = new System.Drawing.Size(945, 632);
            this.Load += new System.EventHandler(this.Result_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer animation_timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Scorer_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScoreLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Current_High_Score;
    }
}
