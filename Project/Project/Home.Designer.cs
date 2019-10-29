using System;

namespace Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Button();
            this.Tips = new System.Windows.Forms.Button();
            this.FAQ = new System.Windows.Forms.Button();
            this.CustomTest = new System.Windows.Forms.Button();
            this.NormalTest = new System.Windows.Forms.Button();
            this.TopBar = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.MaximizeToNormal = new System.Windows.Forms.Button();
            this.normalTestPage1 = new Project.NormalTestPage();
            this.faqPage1 = new Project.FAQPage();
            this.aboutPage1 = new Project.AboutPage();
            this.tipsPage1 = new Project.TipsPage();
            this.customTestPage1 = new Project.CustomTestPage();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.About);
            this.SidePanel.Controls.Add(this.Tips);
            this.SidePanel.Controls.Add(this.FAQ);
            this.SidePanel.Controls.Add(this.CustomTest);
            this.SidePanel.Controls.Add(this.NormalTest);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 672);
            this.SidePanel.TabIndex = 0;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = global::Project.Properties.Resources.About;
            this.About.Location = new System.Drawing.Point(0, 576);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(250, 96);
            this.About.TabIndex = 5;
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
            this.Tips.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Tips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Tips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Tips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tips.ForeColor = System.Drawing.Color.White;
            this.Tips.Image = global::Project.Properties.Resources.Tips;
            this.Tips.Location = new System.Drawing.Point(0, 474);
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(250, 96);
            this.Tips.TabIndex = 4;
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
            this.FAQ.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.FAQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.FAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.FAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAQ.ForeColor = System.Drawing.Color.White;
            this.FAQ.Image = global::Project.Properties.Resources.FAQ;
            this.FAQ.Location = new System.Drawing.Point(0, 372);
            this.FAQ.Name = "FAQ";
            this.FAQ.Size = new System.Drawing.Size(250, 96);
            this.FAQ.TabIndex = 3;
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
            this.CustomTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.CustomTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.CustomTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.CustomTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomTest.ForeColor = System.Drawing.Color.White;
            this.CustomTest.Image = global::Project.Properties.Resources.settings;
            this.CustomTest.Location = new System.Drawing.Point(0, 270);
            this.CustomTest.Name = "CustomTest";
            this.CustomTest.Size = new System.Drawing.Size(250, 96);
            this.CustomTest.TabIndex = 2;
            this.CustomTest.Text = "Custom Test";
            this.CustomTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CustomTest.UseVisualStyleBackColor = false;
            this.CustomTest.Click += new System.EventHandler(this.CustomTest_Click);
            // 
            // NormalTest
            // 
            this.NormalTest.BackColor = System.Drawing.Color.Transparent;
            this.NormalTest.FlatAppearance.BorderSize = 0;
            this.NormalTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.NormalTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.NormalTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.NormalTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalTest.ForeColor = System.Drawing.Color.White;
            this.NormalTest.Image = ((System.Drawing.Image)(resources.GetObject("NormalTest.Image")));
            this.NormalTest.Location = new System.Drawing.Point(0, 168);
            this.NormalTest.Name = "NormalTest";
            this.NormalTest.Size = new System.Drawing.Size(250, 96);
            this.NormalTest.TabIndex = 1;
            this.NormalTest.Text = "Normal Test";
            this.NormalTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NormalTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NormalTest.UseVisualStyleBackColor = false;
            this.NormalTest.Click += new System.EventHandler(this.NormalTest_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(250, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(945, 10);
            this.TopBar.TabIndex = 0;
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
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1168, 10);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 27);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(1114, 10);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 27);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize.Location = new System.Drawing.Point(1141, 10);
            this.Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(27, 27);
            this.Maximize.TabIndex = 12;
            this.Maximize.Text = "☐";
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // MaximizeToNormal
            // 
            this.MaximizeToNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeToNormal.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeToNormal.FlatAppearance.BorderSize = 0;
            this.MaximizeToNormal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.MaximizeToNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.MaximizeToNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.MaximizeToNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeToNormal.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeToNormal.Location = new System.Drawing.Point(1141, 10);
            this.MaximizeToNormal.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeToNormal.Name = "MaximizeToNormal";
            this.MaximizeToNormal.Size = new System.Drawing.Size(27, 27);
            this.MaximizeToNormal.TabIndex = 13;
            this.MaximizeToNormal.Text = "❐";
            this.MaximizeToNormal.UseVisualStyleBackColor = false;
            this.MaximizeToNormal.Visible = false;
            this.MaximizeToNormal.Click += new System.EventHandler(this.MaximizeToNormal_Click);
            // 
            // normalTestPage1
            // 
            this.normalTestPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.normalTestPage1.BackColor = System.Drawing.Color.White;
            this.normalTestPage1.Location = new System.Drawing.Point(0, 40);
            this.normalTestPage1.Name = "normalTestPage1";
            this.normalTestPage1.Size = new System.Drawing.Size(1195, 632);
            this.normalTestPage1.TabIndex = 16;
            // 
            // faqPage1
            // 
            this.faqPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faqPage1.BackColor = System.Drawing.Color.White;
            this.faqPage1.Location = new System.Drawing.Point(250, 40);
            this.faqPage1.Name = "faqPage1";
            this.faqPage1.Size = new System.Drawing.Size(945, 632);
            this.faqPage1.TabIndex = 15;
            this.faqPage1.Visible = false;
            // 
            // aboutPage1
            // 
            this.aboutPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutPage1.BackColor = System.Drawing.Color.Transparent;
            this.aboutPage1.Location = new System.Drawing.Point(250, 40);
            this.aboutPage1.Name = "aboutPage1";
            this.aboutPage1.Size = new System.Drawing.Size(945, 632);
            this.aboutPage1.TabIndex = 10;
            this.aboutPage1.Visible = false;
            // 
            // tipsPage1
            // 
            this.tipsPage1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipsPage1.BackColor = System.Drawing.Color.White;
            this.tipsPage1.Location = new System.Drawing.Point(250, 40);
            this.tipsPage1.Name = "tipsPage1";
            this.tipsPage1.Size = new System.Drawing.Size(945, 632);
            this.tipsPage1.TabIndex = 9;
            this.tipsPage1.Visible = false;
            // 
            // customTestPage1
            // 
            this.customTestPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTestPage1.BackColor = System.Drawing.Color.White;
            this.customTestPage1.Location = new System.Drawing.Point(0, 40);
            this.customTestPage1.Name = "customTestPage1";
            this.customTestPage1.Size = new System.Drawing.Size(1195, 632);
            this.customTestPage1.TabIndex = 14;
            this.customTestPage1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 672);
            this.Controls.Add(this.MaximizeToNormal);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.aboutPage1);
            this.Controls.Add(this.tipsPage1);
            this.Controls.Add(this.customTestPage1);
            this.Controls.Add(this.normalTestPage1);
            this.Controls.Add(this.faqPage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Tips;
        private System.Windows.Forms.Button FAQ;
        private System.Windows.Forms.Button CustomTest;
        private System.Windows.Forms.Button NormalTest;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private TipsPage tipsPage1;
        private AboutPage aboutPage1;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button MaximizeToNormal;
        private CustomTestPage customTestPage1;
        private FAQPage faqPage1;
        private NormalTestPage normalTestPage1;
    }
}

