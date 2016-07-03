namespace EPrime
{
    partial class helpForm
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
            this.helpBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // helpBox
            // 
            this.helpBox.Location = new System.Drawing.Point(12, 12);
            this.helpBox.Name = "helpBox";
            this.helpBox.ReadOnly = true;
            this.helpBox.Size = new System.Drawing.Size(439, 267);
            this.helpBox.TabIndex = 0;
            this.helpBox.Text = "";
            this.helpBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.helpBox_LinkClicked);
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 291);
            this.Controls.Add(this.helpBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "helpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.helpForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpBox;
    }
}