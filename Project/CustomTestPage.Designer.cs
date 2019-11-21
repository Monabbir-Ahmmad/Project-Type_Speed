namespace Project
{
    partial class CustomTestPage
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
            this.CTpanel = new System.Windows.Forms.Panel();
            this.ParagraphBox = new System.Windows.Forms.RichTextBox();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WPMLB = new System.Windows.Forms.Label();
            this.MistypeLB = new System.Windows.Forms.Label();
            this.CharactersTypedLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.Back2 = new Project.RoundButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TSidePanel = new System.Windows.Forms.Panel();
            this.Back1 = new Project.RoundButton();
            this.ParagraphPaste = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.StartTest = new Project.RoundButton();
            this.TimeSet = new System.Windows.Forms.TextBox();
            this.CTpanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.TSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CTpanel
            // 
            this.CTpanel.BackColor = System.Drawing.Color.Transparent;
            this.CTpanel.Controls.Add(this.ParagraphBox);
            this.CTpanel.Controls.Add(this.InputBox);
            this.CTpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTpanel.Location = new System.Drawing.Point(250, 0);
            this.CTpanel.Name = "CTpanel";
            this.CTpanel.Size = new System.Drawing.Size(945, 632);
            this.CTpanel.TabIndex = 44;
            this.CTpanel.Visible = false;
            // 
            // ParagraphBox
            // 
            this.ParagraphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ParagraphBox.BackColor = System.Drawing.Color.Silver;
            this.ParagraphBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParagraphBox.Enabled = false;
            this.ParagraphBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphBox.ForeColor = System.Drawing.Color.Black;
            this.ParagraphBox.Location = new System.Drawing.Point(19, 12);
            this.ParagraphBox.Name = "ParagraphBox";
            this.ParagraphBox.ReadOnly = true;
            this.ParagraphBox.Size = new System.Drawing.Size(907, 425);
            this.ParagraphBox.TabIndex = 6;
            this.ParagraphBox.Text = "";
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.BackColor = System.Drawing.Color.Silver;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.Color.Black;
            this.InputBox.Location = new System.Drawing.Point(61, 452);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(823, 170);
            this.InputBox.TabIndex = 5;
            this.InputBox.Text = "";
            this.InputBox.Click += new System.EventHandler(this.InputBoxClick);
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.SidePanel.Controls.Add(this.label4);
            this.SidePanel.Controls.Add(this.label3);
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Controls.Add(this.WPMLB);
            this.SidePanel.Controls.Add(this.MistypeLB);
            this.SidePanel.Controls.Add(this.CharactersTypedLB);
            this.SidePanel.Controls.Add(this.TimeLB);
            this.SidePanel.Controls.Add(this.Back2);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 632);
            this.SidePanel.TabIndex = 45;
            this.SidePanel.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(18, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 50);
            this.label4.TabIndex = 50;
            this.label4.Text = "Characters Typed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(18, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 50);
            this.label3.TabIndex = 49;
            this.label3.Text = "Words Per Minute";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 50);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mistype";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 50);
            this.label1.TabIndex = 47;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WPMLB
            // 
            this.WPMLB.BackColor = System.Drawing.Color.White;
            this.WPMLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WPMLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WPMLB.Location = new System.Drawing.Point(18, 411);
            this.WPMLB.Name = "WPMLB";
            this.WPMLB.Size = new System.Drawing.Size(212, 62);
            this.WPMLB.TabIndex = 44;
            this.WPMLB.Text = "0 wpm";
            this.WPMLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MistypeLB
            // 
            this.MistypeLB.BackColor = System.Drawing.Color.White;
            this.MistypeLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MistypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MistypeLB.Location = new System.Drawing.Point(18, 287);
            this.MistypeLB.Name = "MistypeLB";
            this.MistypeLB.Size = new System.Drawing.Size(212, 62);
            this.MistypeLB.TabIndex = 43;
            this.MistypeLB.Text = "0";
            this.MistypeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharactersTypedLB
            // 
            this.CharactersTypedLB.BackColor = System.Drawing.Color.White;
            this.CharactersTypedLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharactersTypedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharactersTypedLB.Location = new System.Drawing.Point(18, 535);
            this.CharactersTypedLB.Name = "CharactersTypedLB";
            this.CharactersTypedLB.Size = new System.Drawing.Size(212, 62);
            this.CharactersTypedLB.TabIndex = 45;
            this.CharactersTypedLB.Text = "0";
            this.CharactersTypedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLB
            // 
            this.TimeLB.BackColor = System.Drawing.Color.White;
            this.TimeLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.Location = new System.Drawing.Point(18, 163);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(212, 62);
            this.TimeLB.TabIndex = 3;
            this.TimeLB.Text = "000 s";
            this.TimeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back2
            // 
            this.Back2.BackColor = System.Drawing.Color.Transparent;
            this.Back2.FlatAppearance.BorderSize = 0;
            this.Back2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Back2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Back2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back2.Image = global::Project.Properties.Resources.BackButton;
            this.Back2.Location = new System.Drawing.Point(92, 26);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(65, 65);
            this.Back2.TabIndex = 46;
            this.Back2.UseVisualStyleBackColor = false;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TSidePanel
            // 
            this.TSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TSidePanel.Controls.Add(this.SidePanel);
            this.TSidePanel.Controls.Add(this.Back1);
            this.TSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TSidePanel.Location = new System.Drawing.Point(0, 0);
            this.TSidePanel.Name = "TSidePanel";
            this.TSidePanel.Size = new System.Drawing.Size(250, 632);
            this.TSidePanel.TabIndex = 51;
            // 
            // Back1
            // 
            this.Back1.BackColor = System.Drawing.Color.Transparent;
            this.Back1.FlatAppearance.BorderSize = 0;
            this.Back1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Back1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Back1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back1.Image = global::Project.Properties.Resources.BackButton;
            this.Back1.Location = new System.Drawing.Point(92, 26);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(65, 65);
            this.Back1.TabIndex = 47;
            this.Back1.UseVisualStyleBackColor = false;
            this.Back1.Click += new System.EventHandler(this.Back1_Click);
            // 
            // ParagraphPaste
            // 
            this.ParagraphPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ParagraphPaste.BackColor = System.Drawing.Color.Silver;
            this.ParagraphPaste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParagraphPaste.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphPaste.ForeColor = System.Drawing.Color.Black;
            this.ParagraphPaste.Location = new System.Drawing.Point(268, 73);
            this.ParagraphPaste.Name = "ParagraphPaste";
            this.ParagraphPaste.Size = new System.Drawing.Size(908, 276);
            this.ParagraphPaste.TabIndex = 46;
            this.ParagraphPaste.Text = "";
            this.ParagraphPaste.TextChanged += new System.EventHandler(this.ParagraphPaste_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(593, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 31);
            this.label13.TabIndex = 47;
            this.label13.Text = "Paste the paragraph";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(643, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 31);
            this.label14.TabIndex = 48;
            this.label14.Text = "Set the time";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(783, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 31);
            this.label15.TabIndex = 49;
            this.label15.Text = "s";
            // 
            // StartTest
            // 
            this.StartTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StartTest.FlatAppearance.BorderSize = 0;
            this.StartTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.StartTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.StartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTest.Image = global::Project.Properties.Resources.start;
            this.StartTest.Location = new System.Drawing.Point(681, 504);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(83, 83);
            this.StartTest.TabIndex = 50;
            this.StartTest.UseVisualStyleBackColor = false;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // TimeSet
            // 
            this.TimeSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeSet.BackColor = System.Drawing.Color.Silver;
            this.TimeSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeSet.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSet.Location = new System.Drawing.Point(668, 445);
            this.TimeSet.MaxLength = 3;
            this.TimeSet.Name = "TimeSet";
            this.TimeSet.Size = new System.Drawing.Size(109, 34);
            this.TimeSet.TabIndex = 52;
            this.TimeSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomTestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CTpanel);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ParagraphPaste);
            this.Controls.Add(this.TSidePanel);
            this.Controls.Add(this.TimeSet);
            this.Name = "CustomTestPage";
            this.Size = new System.Drawing.Size(1195, 632);
            this.Load += new System.EventHandler(this.CustomTestPage_Load);
            this.CTpanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.TSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CTpanel;
        private System.Windows.Forms.RichTextBox ParagraphBox;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WPMLB;
        private System.Windows.Forms.Label MistypeLB;
        private System.Windows.Forms.Label CharactersTypedLB;
        private System.Windows.Forms.Label TimeLB;
        private RoundButton Back2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TSidePanel;
        private RoundButton Back1;
        private System.Windows.Forms.RichTextBox ParagraphPaste;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private RoundButton StartTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeSet;
    }
}
