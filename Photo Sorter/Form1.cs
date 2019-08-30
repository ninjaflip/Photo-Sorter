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
            DialogResult testResult = MessageBox.Show("Browse Test Successful! Click OK to close.");
            if (testResult == DialogResult.OK)
            {
                this.Close();
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
