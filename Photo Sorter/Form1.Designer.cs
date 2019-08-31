namespace Photo_Sorter
{
    partial class Form1
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
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.AutoDetectButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SDCardLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(109, 47);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(223, 20);
            this.FilePathText.TabIndex = 2;
            this.FilePathText.TextChanged += new System.EventHandler(this.FilePathText_TextChanged);
            // 
            // AutoDetectButton
            // 
            this.AutoDetectButton.Location = new System.Drawing.Point(431, 47);
            this.AutoDetectButton.Name = "AutoDetectButton";
            this.AutoDetectButton.Size = new System.Drawing.Size(87, 20);
            this.AutoDetectButton.TabIndex = 3;
            this.AutoDetectButton.Text = "Auto-Detect";
            this.AutoDetectButton.UseVisualStyleBackColor = true;
            this.AutoDetectButton.Click += new System.EventHandler(this.AutoDetectButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(338, 47);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(87, 20);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SDCardLabel
            // 
            this.SDCardLabel.AutoSize = true;
            this.SDCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDCardLabel.Location = new System.Drawing.Point(14, 49);
            this.SDCardLabel.Name = "SDCardLabel";
            this.SDCardLabel.Size = new System.Drawing.Size(89, 16);
            this.SDCardLabel.TabIndex = 6;
            this.SDCardLabel.Text = "SD Card Path";
            this.SDCardLabel.Click += new System.EventHandler(this.SDCardLabel_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(223, 73);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(84, 24);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 120);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SDCardLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.AutoDetectButton);
            this.Controls.Add(this.FilePathText);
            this.Name = "Form1";
            this.Text = "Photo Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Button AutoDetectButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label SDCardLabel;
        private System.Windows.Forms.Button NextButton;
    }
}

