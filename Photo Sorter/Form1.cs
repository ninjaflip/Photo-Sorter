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
        }

        //All Form Components

        private void AutoDetectButton_Click(object sender, EventArgs e)
        {
            //Testing button functions
            DialogResult testResult = MessageBox.Show("AutoDetect Test Successful! Click OK to close.");
            if (testResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            //Testing button functions
            /*
            DialogResult testResult = MessageBox.Show("Browse Test Successful! Click OK to close.");
            if (testResult == DialogResult.OK)
            {
                this.Close();
            }
            */
            try
            {
                OpenFileDialog imgObj = new OpenFileDialog();

                //filters that object to open certain image files
                //Version 1.0: Support for ARW files so far 
                imgObj.Filter = "Image Files (*.jpg;*.jpeg;*.arw)|*.jpg;*.jpeg;*.arw";
                imgObj.Title = "Selecting files...";

                //Setting initial directory to SD card

                imgObj.Multiselect = true;
                //if the file dialog opens, grab the location of the image and its filename
                if (imgObj.ShowDialog() == DialogResult.OK)                                                            
                {
                    FilePathText.Text = imgObj.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SDCardLabel_Click(object sender, EventArgs e)
        {

        }

        private void FilePathText_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
