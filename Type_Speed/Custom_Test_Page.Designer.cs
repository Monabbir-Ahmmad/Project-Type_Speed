namespace Type_Speed
{
    partial class Custom_Test_Page
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BackToHome = new WindowsFormsApplication1.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Test = new WindowsFormsApplication1.RoundButton();
            this.ParagraphPasteBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TimeSet = new System.Windows.Forms.TextBox();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.test_Page1 = new Type_Speed.Test_Page();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.SidePanel.Controls.Add(this.BackToHome);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 632);
            this.SidePanel.TabIndex = 20;
            // 
            // BackToHome
            // 
            this.BackToHome.FlatAppearance.BorderSize = 0;
            this.BackToHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BackToHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHome.Image = global::Type_Speed.Properties.Resources.BackButton;
            this.BackToHome.Location = new System.Drawing.Point(88, 31);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(75, 75);
            this.BackToHome.TabIndex = 10;
            this.BackToHome.TabStop = false;
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 217);
            this.label1.TabIndex = 86;
            this.label1.Text = "Note: The required minimum character length for a paragraph is 30 and maximum len" +
    "gth is 1000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_Test
            // 
            this.Start_Test.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Start_Test.FlatAppearance.BorderSize = 0;
            this.Start_Test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Start_Test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Start_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Test.Image = global::Type_Speed.Properties.Resources.Start;
            this.Start_Test.Location = new System.Drawing.Point(682, 521);
            this.Start_Test.Name = "Start_Test";
            this.Start_Test.Size = new System.Drawing.Size(80, 80);
            this.Start_Test.TabIndex = 83;
            this.Start_Test.TabStop = false;
            this.Start_Test.UseVisualStyleBackColor = false;
            this.Start_Test.Click += new System.EventHandler(this.Start_Test_Click);
            // 
            // ParagraphPasteBox
            // 
            this.ParagraphPasteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ParagraphPasteBox.BackColor = System.Drawing.Color.Silver;
            this.ParagraphPasteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParagraphPasteBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphPasteBox.Location = new System.Drawing.Point(268, 78);
            this.ParagraphPasteBox.MaxLength = 1000;
            this.ParagraphPasteBox.Multiline = true;
            this.ParagraphPasteBox.Name = "ParagraphPasteBox";
            this.ParagraphPasteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ParagraphPasteBox.Size = new System.Drawing.Size(927, 276);
            this.ParagraphPasteBox.TabIndex = 82;
            this.ParagraphPasteBox.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(783, 463);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 31);
            this.label15.TabIndex = 80;
            this.label15.Text = "s";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(616, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 31);
            this.label14.TabIndex = 79;
            this.label14.Text = "Set the time limit";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(593, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 31);
            this.label13.TabIndex = 78;
            this.label13.Text = "Paste the paragraph";
            // 
            // TimeSet
            // 
            this.TimeSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeSet.BackColor = System.Drawing.Color.Silver;
            this.TimeSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeSet.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSet.Location = new System.Drawing.Point(668, 456);
            this.TimeSet.MaxLength = 3;
            this.TimeSet.Name = "TimeSet";
            this.TimeSet.Size = new System.Drawing.Size(109, 41);
            this.TimeSet.TabIndex = 81;
            this.TimeSet.TabStop = false;
            this.TimeSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Load_Button
            // 
            this.Load_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Load_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Load_Button.FlatAppearance.BorderSize = 0;
            this.Load_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Load_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Button.ForeColor = System.Drawing.Color.White;
            this.Load_Button.Location = new System.Drawing.Point(268, 360);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(77, 30);
            this.Load_Button.TabIndex = 85;
            this.Load_Button.TabStop = false;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = false;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Save_Button.FlatAppearance.BorderSize = 0;
            this.Save_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Save_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.Location = new System.Drawing.Point(365, 360);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(77, 30);
            this.Save_Button.TabIndex = 86;
            this.Save_Button.TabStop = false;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // test_Page1
            // 
            this.test_Page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.test_Page1.BackColor = System.Drawing.Color.White;
            this.test_Page1.Location = new System.Drawing.Point(0, 0);
            this.test_Page1.Name = "test_Page1";
            this.test_Page1.Size = new System.Drawing.Size(1195, 632);
            this.test_Page1.TabIndex = 87;
            // 
            // Custom_Test_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.test_Page1);
            this.Controls.Add(this.Start_Test);
            this.Controls.Add(this.ParagraphPasteBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TimeSet);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Load_Button);
            this.Name = "Custom_Test_Page";
            this.Size = new System.Drawing.Size(1195, 632);
            this.Load += new System.EventHandler(this.Custom_Test_Page_Load);
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private WindowsFormsApplication1.RoundButton BackToHome;
#pragma warning disable CS0169 // The field 'Custom_Test_Page.panel1' is never used
        private System.Windows.Forms.Panel panel1;
#pragma warning restore CS0169 // The field 'Custom_Test_Page.panel1' is never used
        private System.Windows.Forms.TextBox ParagraphPasteBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TimeSet;
        private WindowsFormsApplication1.RoundButton Start_Test;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label label1;
        private Test_Page test_Page1;
    }
}
