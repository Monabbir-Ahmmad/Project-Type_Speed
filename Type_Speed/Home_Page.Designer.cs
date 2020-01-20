namespace Type_Speed
{
    partial class Home_Page
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.TopBar = new System.Windows.Forms.Panel();
            this.Maximize = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.NormalTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Button();
            this.Tips = new System.Windows.Forms.Button();
            this.FAQ = new System.Windows.Forms.Button();
            this.CustomTest = new System.Windows.Forms.Button();
            this.custom_Test_Page1 = new Type_Speed.Custom_Test_Page();
            this.test_Page1 = new Type_Speed.Test_Page();
            this.faQ_Page1 = new Type_Speed.FAQ_Page();
            this.tips_Page1 = new Type_Speed.Tips_Page();
            this.about_Page1 = new Type_Speed.About_Page();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1195, 10);
            this.TopBar.TabIndex = 1;
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize.Location = new System.Drawing.Point(1141, 10);
            this.Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(27, 27);
            this.Maximize.TabIndex = 16;
            this.Maximize.TabStop = false;
            this.Maximize.Text = "☐";
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(1114, 10);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 27);
            this.Minimize.TabIndex = 15;
            this.Minimize.TabStop = false;
            this.Minimize.Text = "─";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1168, 10);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 27);
            this.Exit.TabIndex = 14;
            this.Exit.TabStop = false;
            this.Exit.Text = "✕";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.SidePanel.Controls.Add(this.NormalTest);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.About);
            this.SidePanel.Controls.Add(this.Tips);
            this.SidePanel.Controls.Add(this.FAQ);
            this.SidePanel.Controls.Add(this.CustomTest);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 10);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 662);
            this.SidePanel.TabIndex = 18;
            // 
            // NormalTest
            // 
            this.NormalTest.BackColor = System.Drawing.Color.Transparent;
            this.NormalTest.FlatAppearance.BorderSize = 0;
            this.NormalTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.NormalTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.NormalTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.NormalTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalTest.ForeColor = System.Drawing.Color.White;
            this.NormalTest.Image = global::Type_Speed.Properties.Resources.Keyboard;
            this.NormalTest.Location = new System.Drawing.Point(0, 182);
            this.NormalTest.Margin = new System.Windows.Forms.Padding(0);
            this.NormalTest.Name = "NormalTest";
            this.NormalTest.Size = new System.Drawing.Size(250, 96);
            this.NormalTest.TabIndex = 1;
            this.NormalTest.TabStop = false;
            this.NormalTest.Text = "Normal Test";
            this.NormalTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NormalTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NormalTest.UseVisualStyleBackColor = false;
            this.NormalTest.Click += new System.EventHandler(this.NormalTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Type_Speed.Properties.Resources.TypeSpeed;
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = global::Type_Speed.Properties.Resources.About;
            this.About.Location = new System.Drawing.Point(0, 566);
            this.About.Margin = new System.Windows.Forms.Padding(0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(250, 96);
            this.About.TabIndex = 5;
            this.About.TabStop = false;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Tips
            // 
            this.Tips.BackColor = System.Drawing.Color.Transparent;
            this.Tips.FlatAppearance.BorderSize = 0;
            this.Tips.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tips.ForeColor = System.Drawing.Color.White;
            this.Tips.Image = global::Type_Speed.Properties.Resources.Tips;
            this.Tips.Location = new System.Drawing.Point(0, 470);
            this.Tips.Margin = new System.Windows.Forms.Padding(0);
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(250, 96);
            this.Tips.TabIndex = 4;
            this.Tips.TabStop = false;
            this.Tips.Text = "Tips";
            this.Tips.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Tips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tips.UseVisualStyleBackColor = false;
            this.Tips.Click += new System.EventHandler(this.Tips_Click);
            // 
            // FAQ
            // 
            this.FAQ.BackColor = System.Drawing.Color.Transparent;
            this.FAQ.FlatAppearance.BorderSize = 0;
            this.FAQ.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FAQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAQ.ForeColor = System.Drawing.Color.White;
            this.FAQ.Image = global::Type_Speed.Properties.Resources.FAQ;
            this.FAQ.Location = new System.Drawing.Point(0, 374);
            this.FAQ.Margin = new System.Windows.Forms.Padding(0);
            this.FAQ.Name = "FAQ";
            this.FAQ.Size = new System.Drawing.Size(250, 96);
            this.FAQ.TabIndex = 3;
            this.FAQ.TabStop = false;
            this.FAQ.Text = "FAQ";
            this.FAQ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FAQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FAQ.UseVisualStyleBackColor = false;
            this.FAQ.Click += new System.EventHandler(this.FAQ_Click);
            // 
            // CustomTest
            // 
            this.CustomTest.BackColor = System.Drawing.Color.Transparent;
            this.CustomTest.FlatAppearance.BorderSize = 0;
            this.CustomTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CustomTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CustomTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CustomTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomTest.ForeColor = System.Drawing.Color.White;
            this.CustomTest.Image = global::Type_Speed.Properties.Resources.Settings;
            this.CustomTest.Location = new System.Drawing.Point(0, 278);
            this.CustomTest.Margin = new System.Windows.Forms.Padding(0);
            this.CustomTest.Name = "CustomTest";
            this.CustomTest.Size = new System.Drawing.Size(250, 96);
            this.CustomTest.TabIndex = 2;
            this.CustomTest.TabStop = false;
            this.CustomTest.Text = "Custom Test";
            this.CustomTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CustomTest.UseVisualStyleBackColor = false;
            this.CustomTest.Click += new System.EventHandler(this.CustomTest_Click);
            // 
            // custom_Test_Page1
            // 
            this.custom_Test_Page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custom_Test_Page1.BackColor = System.Drawing.Color.White;
            this.custom_Test_Page1.Location = new System.Drawing.Point(0, 40);
            this.custom_Test_Page1.Name = "custom_Test_Page1";
            this.custom_Test_Page1.Size = new System.Drawing.Size(1195, 632);
            this.custom_Test_Page1.TabIndex = 19;
            // 
            // test_Page1
            // 
            this.test_Page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.test_Page1.BackColor = System.Drawing.Color.White;
            this.test_Page1.Location = new System.Drawing.Point(0, 40);
            this.test_Page1.Name = "test_Page1";
            this.test_Page1.Size = new System.Drawing.Size(1195, 632);
            this.test_Page1.TabIndex = 20;
            // 
            // faQ_Page1
            // 
            this.faQ_Page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faQ_Page1.BackColor = System.Drawing.Color.White;
            this.faQ_Page1.Location = new System.Drawing.Point(250, 40);
            this.faQ_Page1.Name = "faQ_Page1";
            this.faQ_Page1.Size = new System.Drawing.Size(945, 632);
            this.faQ_Page1.TabIndex = 21;
            // 
            // tips_Page1
            // 
            this.tips_Page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tips_Page1.BackColor = System.Drawing.Color.White;
            this.tips_Page1.Location = new System.Drawing.Point(250, 40);
            this.tips_Page1.Name = "tips_Page1";
            this.tips_Page1.Size = new System.Drawing.Size(945, 632);
            this.tips_Page1.TabIndex = 22;
            // 
            // about_Page1
            // 
            this.about_Page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.about_Page1.BackColor = System.Drawing.Color.White;
            this.about_Page1.Location = new System.Drawing.Point(250, 40);
            this.about_Page1.Name = "about_Page1";
            this.about_Page1.Size = new System.Drawing.Size(945, 632);
            this.about_Page1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(250, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 632);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(824, 116);
            this.label3.TabIndex = 89;
            this.label3.Text = "After a test is completed by finishing the paragraph or reaching the time limit, " +
    "you will get a final score based on your performance.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(824, 116);
            this.label2.TabIndex = 88;
            this.label2.Text = "In \'Custom Test\' you can set you own paragraph and time limit. You can also save " +
    "and load paragraphs as text files.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 116);
            this.label1.TabIndex = 87;
            this.label1.Text = "In \'Normal Test\' there are multiple pre added paragraphs with time limits availab" +
    "le and you will get a random test from these pre added data.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.tips_Page1);
            this.Controls.Add(this.faQ_Page1);
            this.Controls.Add(this.custom_Test_Page1);
            this.Controls.Add(this.test_Page1);
            this.Controls.Add(this.about_Page1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Tips;
        private System.Windows.Forms.Button FAQ;
        private System.Windows.Forms.Button CustomTest;
        private System.Windows.Forms.Button NormalTest;
        private Custom_Test_Page custom_Test_Page1;
        private Test_Page test_Page1;
        private FAQ_Page faQ_Page1;
        private Tips_Page tips_Page1;
        private About_Page about_Page1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

