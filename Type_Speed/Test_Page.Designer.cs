namespace Type_Speed
{
    partial class Test_Page
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Back = new WindowsFormsApplication1.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WPMLB = new System.Windows.Forms.Label();
            this.MistypeLB = new System.Windows.Forms.Label();
            this.CharactersTypedLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.ParagraphBox = new System.Windows.Forms.RichTextBox();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.result_Page1 = new Type_Speed.Result_Page();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.SidePanel.Controls.Add(this.Back);
            this.SidePanel.Controls.Add(this.label4);
            this.SidePanel.Controls.Add(this.label3);
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Controls.Add(this.WPMLB);
            this.SidePanel.Controls.Add(this.MistypeLB);
            this.SidePanel.Controls.Add(this.CharactersTypedLB);
            this.SidePanel.Controls.Add(this.TimeLB);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 632);
            this.SidePanel.TabIndex = 48;
            // 
            // Back
            // 
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Image = global::Type_Speed.Properties.Resources.BackButton;
            this.Back.Location = new System.Drawing.Point(88, 31);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 75);
            this.Back.TabIndex = 51;
            this.Back.TabStop = false;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(18, 511);
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
            this.label3.Location = new System.Drawing.Point(18, 387);
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
            this.label2.Location = new System.Drawing.Point(18, 263);
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
            this.label1.Location = new System.Drawing.Point(18, 139);
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
            this.WPMLB.Location = new System.Drawing.Point(18, 421);
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
            this.MistypeLB.Location = new System.Drawing.Point(18, 297);
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
            this.CharactersTypedLB.Location = new System.Drawing.Point(18, 545);
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
            this.TimeLB.Location = new System.Drawing.Point(18, 173);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(212, 62);
            this.TimeLB.TabIndex = 3;
            this.TimeLB.Text = "000 s";
            this.TimeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParagraphBox
            // 
            this.ParagraphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ParagraphBox.BackColor = System.Drawing.Color.Silver;
            this.ParagraphBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParagraphBox.Enabled = false;
            this.ParagraphBox.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphBox.ForeColor = System.Drawing.Color.Black;
            this.ParagraphBox.Location = new System.Drawing.Point(269, 12);
            this.ParagraphBox.Name = "ParagraphBox";
            this.ParagraphBox.ReadOnly = true;
            this.ParagraphBox.Size = new System.Drawing.Size(907, 425);
            this.ParagraphBox.TabIndex = 50;
            this.ParagraphBox.TabStop = false;
            this.ParagraphBox.Text = "";
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.BackColor = System.Drawing.Color.Silver;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.Color.Black;
            this.InputBox.Location = new System.Drawing.Point(311, 452);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(823, 170);
            this.InputBox.TabIndex = 49;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "";
            this.InputBox.Click += new System.EventHandler(this.InputBoxClick);
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(527, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 39);
            this.label5.TabIndex = 86;
            this.label5.Text = "Click here to start typing";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // result_Page1
            // 
            this.result_Page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_Page1.BackColor = System.Drawing.Color.White;
            this.result_Page1.Location = new System.Drawing.Point(250, 0);
            this.result_Page1.Name = "result_Page1";
            this.result_Page1.Size = new System.Drawing.Size(945, 632);
            this.result_Page1.TabIndex = 87;
            // 
            // Test_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.result_Page1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ParagraphBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.SidePanel);
            this.Name = "Test_Page";
            this.Size = new System.Drawing.Size(1195, 632);
            this.Load += new System.EventHandler(this.Test_Page_Load);
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private WindowsFormsApplication1.RoundButton Back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WPMLB;
        private System.Windows.Forms.Label MistypeLB;
        private System.Windows.Forms.Label CharactersTypedLB;
        public System.Windows.Forms.RichTextBox ParagraphBox;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label TimeLB;
        private Result_Page result_Page1;
    }
}
