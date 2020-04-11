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
        public string directoryPath;


        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            try
            {

                Clear_Textboxes();

                if (PathTextbox.Text.Length > 0 && PathTextbox.Text != "")
                {

                    if (FileButton.Checked)
                    {

                        fileInfo = new FileInfo(PathTextbox.Text);

                        if (fileInfo.Exists)
                        {

                            directoryPath = fileInfo.DirectoryName;

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

                        directoryPath = directoryInfo.FullName;

                        if (directoryInfo.Exists)
                        {

                            FillFiles_Folders_ListBoxes();

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

                if (!FoldersListBox.Items.Contains(folder.Name))
                {
                    FoldersListBox.Items.Add(folder.Name);
                }

            }

            FileInfo[] fileArray = directoryInfo.GetFiles();

            foreach (FileInfo file in fileArray)
            {

                if (!FilesListBox.Items.Contains(file.Name))
                {

                    FilesListBox.Items.Add(file.Name);

                }

            }


        }

        private void FillTextBoxes()
        {

            FileNameTextbox.Text = fileInfo.Name;

            CreationTimeTextbox.Text = fileInfo.CreationTime.ToString();

            FileSizeTextbox.Text = fileInfo.Length.ToString() + " bytes";

            LastAccessTimeTB.Text = fileInfo.LastAccessTime.ToString();

            LastModTextbox.Text = fileInfo.LastWriteTime.ToString();

        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                if (FilesListBox.SelectedIndex != -1)
                {

                    fileInfo = new FileInfo(Path.Combine(directoryPath, FilesListBox.SelectedItem.ToString()));

                    if (fileInfo.Exists)
                    {
                        FillTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("File does not exist or file is incompatible.");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a file to display file info.");
                }

            }
            catch (Exception exc)
            {

                MessageBox.Show("Error has occurred in Files List Box. Refer to following message: \n\n" + exc.Message, "Message from Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Clear_Textboxes()
        {

            FileNameTextbox.Text = "";

            FilesListBox.Items.Clear();

            FoldersListBox.Items.Clear();

            CreationTimeTextbox.Text = "";

            FileSizeTextbox.Text = "";

            LastAccessTimeTB.Text = "";

            LastModTextbox.Text = "";

        }

        private void Folder_SelectedChange(object sender, EventArgs e)
        {

            try
            {

                if (FoldersListBox.SelectedIndex != 1 && FoldersListBox.SelectedItem != null)
                {
                   
                    string selectedFolder = FoldersListBox.SelectedItem.ToString();

                    if (selectedFolder != null && selectedFolder != string.Empty)
                    {

                        string path = Path.Combine(directoryInfo.FullName, selectedFolder);

                        directoryInfo = new DirectoryInfo(path);

                        directoryPath = directoryInfo.FullName;

                        Clear_Textboxes();

                        FillFiles_Folders_ListBoxes();

                    }
                    else
                    {

                        MessageBox.Show("Selected folder cannot be blank!");

                    }
                    
                }
                else
                {

                    MessageBox.Show("Invalid selection! Please select a folder from the list box.");

                }

            }
            catch (Exception exc)
            {

                MessageBox.Show("Error has occurred in Folder_SelectedChange method. Please refer to the following message: \n\n" + exc.Message);

            }

        }
    }
}
