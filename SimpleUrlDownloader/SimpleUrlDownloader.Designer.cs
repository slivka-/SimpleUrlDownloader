namespace UrlDownloader
{
    partial class SimpleUrlDownloader
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
            this.dlButton = new System.Windows.Forms.Button();
            this.dlURLBox = new System.Windows.Forms.TextBox();
            this.dlProgBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // dlButton
            // 
            this.dlButton.Location = new System.Drawing.Point(101, 69);
            this.dlButton.Name = "dlButton";
            this.dlButton.Size = new System.Drawing.Size(75, 23);
            this.dlButton.TabIndex = 0;
            this.dlButton.Text = "Download";
            this.dlButton.UseVisualStyleBackColor = true;
            this.dlButton.Click += new System.EventHandler(this.dlButton_Click);
            // 
            // dlURLBox
            // 
            this.dlURLBox.Location = new System.Drawing.Point(12, 43);
            this.dlURLBox.Name = "dlURLBox";
            this.dlURLBox.Size = new System.Drawing.Size(260, 20);
            this.dlURLBox.TabIndex = 1;
            // 
            // dlProgBar
            // 
            this.dlProgBar.Location = new System.Drawing.Point(13, 13);
            this.dlProgBar.Name = "dlProgBar";
            this.dlProgBar.Size = new System.Drawing.Size(259, 23);
            this.dlProgBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.dlProgBar);
            this.Controls.Add(this.dlURLBox);
            this.Controls.Add(this.dlButton);
            this.Name = "Form1";
            this.Text = "FIle downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dlButton;
        private System.Windows.Forms.TextBox dlURLBox;
        private System.Windows.Forms.ProgressBar dlProgBar;
    }
}

