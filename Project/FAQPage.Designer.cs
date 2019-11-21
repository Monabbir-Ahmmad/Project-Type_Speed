namespace Project
{
    partial class FAQPage
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
            this.FAQTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FAQTextBox
            // 
            this.FAQTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FAQTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.FAQTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FAQTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAQTextBox.Location = new System.Drawing.Point(104, 35);
            this.FAQTextBox.Name = "FAQTextBox";
            this.FAQTextBox.ReadOnly = true;
            this.FAQTextBox.Size = new System.Drawing.Size(737, 562);
            this.FAQTextBox.TabIndex = 11;
            this.FAQTextBox.Text = "This is FAQ";
            // 
            // FAQPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FAQTextBox);
            this.Name = "FAQPage";
            this.Size = new System.Drawing.Size(945, 632);
            this.Load += new System.EventHandler(this.FAQPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FAQTextBox;
    }
}
