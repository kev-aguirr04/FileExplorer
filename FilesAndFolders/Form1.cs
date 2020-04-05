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

                        msgResult = fileInfo.Exists.ToString();

                        creationTime = fileInfo.CreationTime.ToString();

                        lastAccessTime = fileInfo.LastAccessTime.ToString();

                    }
                    else if (FolderButton.Checked)
                    {
                        directoryInfo = new DirectoryInfo(PathTextbox.Text);

                        msgResult = directoryInfo.Exists.ToString();

                        creationTime = directoryInfo.CreationTime.ToString();

                        lastAccessTime = directoryInfo.LastAccessTime.ToString();

                    }

                    MessageBox.Show("Was the folder or file found on the system?: " + msgResult);

                    FillTextBoxes();

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

        private void FillTextBoxes()
        {

            CreationTimeTextbox.Text = creationTime;

            LastAccessTimeTB.Text = lastAccessTime;

            textBox1.Text = Path.Combine(@"C:\Users\kevin\Documents\SQL Server 2012 Scripts\Code Samples - Final", "Chapter4DB.sql");

            

        }
    }
}
