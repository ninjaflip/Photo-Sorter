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

        //Create list of Panels to enable next panel page
        //index through them to move between each panel
        List<Panel> panel_List = new List<Panel>();
        int pageIndex;

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
        private void PrevButton_Click(object sender, EventArgs e)
        {
           //Brings previous page up
           if(pageIndex > 0)
            {
                panel_List[--pageIndex].BringToFront();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(FolderPath);

           //Brings next page up 
           if(pageIndex < panel_List.Count -1)
            {
                panel_List[++pageIndex].BringToFront();
            }
        }


        //Labels and textbox section
        private void FilePathText_TextChanged(object sender, EventArgs e)
        {

        }


        private void SDCardLabel_Click(object sender, EventArgs e)
        {

        }


        //Form loader to load the panels
        private void Form1_Load(object sender, EventArgs e)
        {
            //List of panels
            panel_List.Add(ChooseFilePathPanel);
            panel_List.Add(FolderSortingPanel);

            //Bring to front the first panel
            panel_List[pageIndex].BringToFront();
        }

    }
}
