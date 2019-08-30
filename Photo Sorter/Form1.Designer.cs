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
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.AutoDetectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(338, 47);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(78, 20);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SD Card Location";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(131, 47);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(201, 20);
            this.FilePathText.TabIndex = 2;
            // 
            // AutoDetectButton
            // 
            this.AutoDetectButton.Location = new System.Drawing.Point(422, 47);
            this.AutoDetectButton.Name = "AutoDetectButton";
            this.AutoDetectButton.Size = new System.Drawing.Size(87, 20);
            this.AutoDetectButton.TabIndex = 3;
            this.AutoDetectButton.Text = "Auto-Detect";
            this.AutoDetectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 120);
            this.Controls.Add(this.AutoDetectButton);
            this.Controls.Add(this.FilePathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseButton);
            this.Name = "Form1";
            this.Text = "Photo Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Button AutoDetectButton;
    }
}

