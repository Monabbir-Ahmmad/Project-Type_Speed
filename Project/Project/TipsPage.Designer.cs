namespace Project
{
    partial class TipsPage
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
            this.TipsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TipsTextBox
            // 
            this.TipsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TipsTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.TipsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipsTextBox.Location = new System.Drawing.Point(104, 35);
            this.TipsTextBox.Name = "TipsTextBox";
            this.TipsTextBox.ReadOnly = true;
            this.TipsTextBox.Size = new System.Drawing.Size(737, 562);
            this.TipsTextBox.TabIndex = 10;
            this.TipsTextBox.Text = "This is Tips";
            this.TipsTextBox.TextChanged += new System.EventHandler(this.TipsTextBox_TextChanged);
            // 
            // TipsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TipsTextBox);
            this.Name = "TipsPage";
            this.Size = new System.Drawing.Size(945, 632);
            this.Load += new System.EventHandler(this.TipsPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TipsTextBox;
    }
}
