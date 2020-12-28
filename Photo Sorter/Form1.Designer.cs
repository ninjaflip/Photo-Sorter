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
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SDCardLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.ChooseFilePathPanel = new System.Windows.Forms.Panel();
            this.FolderSortingPanel = new System.Windows.Forms.Panel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.ChooseFilePathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(28, 111);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(316, 20);
            this.FilePathText.TabIndex = 2;
            this.FilePathText.TextChanged += new System.EventHandler(this.FilePathText_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(132, 157);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(100, 20);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SDCardLabel
            // 
            this.SDCardLabel.AutoSize = true;
            this.SDCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDCardLabel.Location = new System.Drawing.Point(119, 63);
            this.SDCardLabel.Name = "SDCardLabel";
            this.SDCardLabel.Size = new System.Drawing.Size(122, 24);
            this.SDCardLabel.TabIndex = 6;
            this.SDCardLabel.Text = "SD Card Path";
            this.SDCardLabel.Click += new System.EventHandler(this.SDCardLabel_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(282, 250);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(155, 39);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ChooseFilePathPanel
            // 
            this.ChooseFilePathPanel.Controls.Add(this.SDCardLabel);
            this.ChooseFilePathPanel.Controls.Add(this.FilePathText);
            this.ChooseFilePathPanel.Controls.Add(this.BrowseButton);
            this.ChooseFilePathPanel.Location = new System.Drawing.Point(62, 12);
            this.ChooseFilePathPanel.Name = "ChooseFilePathPanel";
            this.ChooseFilePathPanel.Size = new System.Drawing.Size(375, 232);
            this.ChooseFilePathPanel.TabIndex = 8;
            // 
            // FolderSortingPanel
            // 
            this.FolderSortingPanel.Location = new System.Drawing.Point(12, 12);
            this.FolderSortingPanel.Name = "FolderSortingPanel";
            this.FolderSortingPanel.Size = new System.Drawing.Size(480, 232);
            this.FolderSortingPanel.TabIndex = 9;
            // 
            // PrevButton
            // 
            this.PrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevButton.Location = new System.Drawing.Point(62, 250);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(155, 39);
            this.PrevButton.TabIndex = 0;
            this.PrevButton.Text = "Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.FolderSortingPanel);
            this.Controls.Add(this.ChooseFilePathPanel);
            this.Controls.Add(this.NextButton);
            this.Name = "Form1";
            this.Text = "Photo Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChooseFilePathPanel.ResumeLayout(false);
            this.ChooseFilePathPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label SDCardLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel ChooseFilePathPanel;
        private System.Windows.Forms.Panel FolderSortingPanel;
        private System.Windows.Forms.Button PrevButton;
    }
}

