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

        private void button1_Click(object sender, EventArgs e)
        {
            //Testing button functions
            MessageBoxButtons closeDiag = MessageBoxButtons.OK;
            DialogResult testResult = MessageBox.Show("Test successful! Click OK to close.");
            if (testResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
