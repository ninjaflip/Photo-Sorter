using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Set properties for parts of app when it loads
            NextButton.Enabled = false;
            FilePathText.ReadOnly = true;
        }

        //Variables within the class
        String FolderPath;
    
        //Buttons section

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SelectedFolder = new FolderBrowserDialog();

            //Folder browser properties
            SelectedFolder.ShowNewFolderButton = false;
            SelectedFolder.Description = "Select folder to be sorted";
            if (SelectedFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePathText.Text = SelectedFolder.SelectedPath;
                FolderPath = SelectedFolder.SelectedPath;
                if(FolderPath != null)
                {
                    NextButton.Enabled = true;
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            
        }


        //Labels and textbox section
        private void FilePathText_TextChanged(object sender, EventArgs e)
        {

        }


        private void SDCardLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
