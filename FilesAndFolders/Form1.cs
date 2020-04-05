using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilesAndFolders
{
    public partial class Form1 : Form
    {

        public string path;
        public FileInfo fileInfo;
        public DirectoryInfo directoryInfo;
        public string msgResult;
        public string creationTime;
        public string lastAccessTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            try
            {

                if (PathTextbox.Text.Length > 0 && PathTextbox.Text != "")
                {

                    if (FileButton.Checked)
                    {

                        fileInfo = new FileInfo(PathTextbox.Text);

                        if (fileInfo.Exists)
                        {

                            creationTime = fileInfo.CreationTime.ToString();

                            lastAccessTime = fileInfo.LastAccessTime.ToString();

                            Fill_Folder_ListBox();

                            FillTextBoxes();

                        }
                        else
                        {
                            MessageBox.Show("File does not exist!");
                        }

                    }
                    else if (FolderButton.Checked)
                    {

                        directoryInfo = new DirectoryInfo(PathTextbox.Text);

                        if (directoryInfo.Exists)
                        {

                            creationTime = directoryInfo.CreationTime.ToString();

                            lastAccessTime = directoryInfo.LastAccessTime.ToString();

                            FillFiles_Folders_ListBoxes();

                            FillTextBoxes();

                        }
                        else
                        {
                            MessageBox.Show("Folder does not exist!");
                        }
                     
                    }
               
                }
                else
                {
                    MessageBox.Show("Invalid entry! Please enter a valid path for a file or folder.");
                }

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);

            }
            
        }

        private void Fill_Folder_ListBox()
        {

            DirectoryInfo directory = fileInfo.Directory;

            if (!FoldersListBox.Items.Contains(directory.Name))
            {
                FoldersListBox.Items.Add(directory.Name);
            }

        }

        private void FillFiles_Folders_ListBoxes()
        {

            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();

            foreach (DirectoryInfo folder in subDirectories)
            {

                if (!FoldersListBox.Items.Contains(folder))
                {
                    FoldersListBox.Items.Add(folder);
                }

            }

            FileInfo[] fileArray = directoryInfo.GetFiles();

            foreach (FileInfo file in fileArray)
            {

                if (!FilesListBox.Items.Contains(file))
                {

                    FilesListBox.Items.Add(file);

                }

            }


        }

        private void FillTextBoxes()
        {

            CreationTimeTextbox.Text = creationTime;

            LastAccessTimeTB.Text = lastAccessTime;
            

        }
    }
}
