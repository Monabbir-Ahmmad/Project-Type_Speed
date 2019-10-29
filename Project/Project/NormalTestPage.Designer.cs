namespace Project
{
    partial class NormalTestPage
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
            this.NTpanel = new System.Windows.Forms.Panel();
            this.ParagraphBox = new System.Windows.Forms.RichTextBox();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.TSidePanel = new System.Windows.Forms.Panel();
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
            this.Back1 = new Project.RoundButton();
            this.Test5 = new System.Windows.Forms.Button();
            this.Test1 = new System.Windows.Forms.Button();
            this.Test4 = new System.Windows.Forms.Button();
            this.Test2 = new System.Windows.Forms.Button();
            this.Test3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NTpanel.SuspendLayout();
            this.TSidePanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NTpanel
            // 
            this.NTpanel.BackColor = System.Drawing.Color.Transparent;
            this.NTpanel.Controls.Add(this.ParagraphBox);
            this.NTpanel.Controls.Add(this.InputBox);
            this.NTpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NTpanel.Location = new System.Drawing.Point(250, 0);
            this.NTpanel.Name = "NTpanel";
            this.NTpanel.Size = new System.Drawing.Size(945, 632);
            this.NTpanel.TabIndex = 0;
            this.NTpanel.Visible = false;
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
            this.InputBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // TSidePanel
            // 
            this.TSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TSidePanel.Controls.Add(this.SidePanel);
            this.TSidePanel.Controls.Add(this.Back1);
            this.TSidePanel.Controls.Add(this.Test5);
            this.TSidePanel.Controls.Add(this.Test1);
            this.TSidePanel.Controls.Add(this.Test4);
            this.TSidePanel.Controls.Add(this.Test2);
            this.TSidePanel.Controls.Add(this.Test3);
            this.TSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TSidePanel.Location = new System.Drawing.Point(0, 0);
            this.TSidePanel.Name = "TSidePanel";
            this.TSidePanel.Size = new System.Drawing.Size(250, 632);
            this.TSidePanel.TabIndex = 19;
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
            this.SidePanel.TabIndex = 43;
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
            // Test5
            // 
            this.Test5.BackColor = System.Drawing.Color.Transparent;
            this.Test5.FlatAppearance.BorderSize = 0;
            this.Test5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test5.ForeColor = System.Drawing.Color.White;
            this.Test5.Location = new System.Drawing.Point(0, 535);
            this.Test5.Name = "Test5";
            this.Test5.Size = new System.Drawing.Size(250, 96);
            this.Test5.TabIndex = 41;
            this.Test5.Text = "Test5";
            this.Test5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Test5.UseVisualStyleBackColor = false;
            this.Test5.Click += new System.EventHandler(this.Test5_Click);
            // 
            // Test1
            // 
            this.Test1.BackColor = System.Drawing.Color.Transparent;
            this.Test1.FlatAppearance.BorderSize = 0;
            this.Test1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test1.ForeColor = System.Drawing.Color.White;
            this.Test1.Location = new System.Drawing.Point(0, 127);
            this.Test1.Name = "Test1";
            this.Test1.Size = new System.Drawing.Size(250, 96);
            this.Test1.TabIndex = 37;
            this.Test1.Text = "Test1";
            this.Test1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Test1.UseVisualStyleBackColor = false;
            this.Test1.Click += new System.EventHandler(this.Test1_Click);
            // 
            // Test4
            // 
            this.Test4.BackColor = System.Drawing.Color.Transparent;
            this.Test4.FlatAppearance.BorderSize = 0;
            this.Test4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test4.ForeColor = System.Drawing.Color.White;
            this.Test4.Location = new System.Drawing.Point(0, 433);
            this.Test4.Name = "Test4";
            this.Test4.Size = new System.Drawing.Size(250, 96);
            this.Test4.TabIndex = 40;
            this.Test4.Text = "Test4";
            this.Test4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Test4.UseVisualStyleBackColor = false;
            this.Test4.Click += new System.EventHandler(this.Test4_Click_1);
            // 
            // Test2
            // 
            this.Test2.BackColor = System.Drawing.Color.Transparent;
            this.Test2.FlatAppearance.BorderSize = 0;
            this.Test2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test2.ForeColor = System.Drawing.Color.White;
            this.Test2.Location = new System.Drawing.Point(0, 229);
            this.Test2.Name = "Test2";
            this.Test2.Size = new System.Drawing.Size(250, 96);
            this.Test2.TabIndex = 38;
            this.Test2.Text = "Test2";
            this.Test2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Test2.UseVisualStyleBackColor = false;
            this.Test2.Click += new System.EventHandler(this.Test2_Click);
            // 
            // Test3
            // 
            this.Test3.BackColor = System.Drawing.Color.Transparent;
            this.Test3.FlatAppearance.BorderSize = 0;
            this.Test3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.Test3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test3.ForeColor = System.Drawing.Color.White;
            this.Test3.Location = new System.Drawing.Point(0, 331);
            this.Test3.Name = "Test3";
            this.Test3.Size = new System.Drawing.Size(250, 96);
            this.Test3.TabIndex = 39;
            this.Test3.Text = "Test3";
            this.Test3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Test3.UseVisualStyleBackColor = false;
            this.Test3.Click += new System.EventHandler(this.Test3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NormalTestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NTpanel);
            this.Controls.Add(this.TSidePanel);
            this.Name = "NormalTestPage";
            this.Size = new System.Drawing.Size(1195, 632);
            this.Load += new System.EventHandler(this.NTPage_Load);
            this.NTpanel.ResumeLayout(false);
            this.TSidePanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NTpanel;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Panel TSidePanel;
        private System.Windows.Forms.Button Test5;
        private System.Windows.Forms.Button Test1;
        private System.Windows.Forms.Button Test3;
        private System.Windows.Forms.Button Test2;
        private System.Windows.Forms.Button Test4;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label CharactersTypedLB;
        private System.Windows.Forms.Label WPMLB;
        private System.Windows.Forms.Label MistypeLB;
        private System.Windows.Forms.Timer timer1;
        private RoundButton Back2;
        private RoundButton Back1;
        private System.Windows.Forms.RichTextBox ParagraphBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
