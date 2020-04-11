namespace FilesAndFolders
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
            this.PathTextbox = new System.Windows.Forms.TextBox();
            this.FileSystemLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.RadioButton();
            this.FolderButton = new System.Windows.Forms.RadioButton();
            this.CreationLabel = new System.Windows.Forms.Label();
            this.CreationTimeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastAccessTimeTB = new System.Windows.Forms.TextBox();
            this.FoldersListBox = new System.Windows.Forms.ListBox();
            this.FileTypeLabelOption = new System.Windows.Forms.Label();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FolderLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextbox = new System.Windows.Forms.TextBox();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.FileSizeTextbox = new System.Windows.Forms.TextBox();
            this.LastModLabel = new System.Windows.Forms.Label();
            this.LastModTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PathTextbox
            // 
            this.PathTextbox.Location = new System.Drawing.Point(143, 62);
            this.PathTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.Size = new System.Drawing.Size(206, 20);
            this.PathTextbox.TabIndex = 0;
            // 
            // FileSystemLabel
            // 
            this.FileSystemLabel.AutoSize = true;
            this.FileSystemLabel.Location = new System.Drawing.Point(23, 65);
            this.FileSystemLabel.Name = "FileSystemLabel";
            this.FileSystemLabel.Size = new System.Drawing.Size(115, 13);
            this.FileSystemLabel.TabIndex = 1;
            this.FileSystemLabel.Text = "Enter your file or folder:";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(365, 62);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Check";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FileButton
            // 
            this.FileButton.AutoSize = true;
            this.FileButton.Checked = true;
            this.FileButton.Location = new System.Drawing.Point(163, 27);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(41, 17);
            this.FileButton.TabIndex = 3;
            this.FileButton.TabStop = true;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            // 
            // FolderButton
            // 
            this.FolderButton.AutoSize = true;
            this.FolderButton.Location = new System.Drawing.Point(231, 27);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(54, 17);
            this.FolderButton.TabIndex = 4;
            this.FolderButton.TabStop = true;
            this.FolderButton.Text = "Folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            // 
            // CreationLabel
            // 
            this.CreationLabel.AutoSize = true;
            this.CreationLabel.Location = new System.Drawing.Point(12, 410);
            this.CreationLabel.Name = "CreationLabel";
            this.CreationLabel.Size = new System.Drawing.Size(75, 13);
            this.CreationLabel.TabIndex = 5;
            this.CreationLabel.Text = "Creation Time:";
            // 
            // CreationTimeTextbox
            // 
            this.CreationTimeTextbox.Enabled = false;
            this.CreationTimeTextbox.Location = new System.Drawing.Point(12, 435);
            this.CreationTimeTextbox.Name = "CreationTimeTextbox";
            this.CreationTimeTextbox.Size = new System.Drawing.Size(209, 20);
            this.CreationTimeTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Access Time:";
            // 
            // LastAccessTimeTB
            // 
            this.LastAccessTimeTB.Enabled = false;
            this.LastAccessTimeTB.Location = new System.Drawing.Point(12, 496);
            this.LastAccessTimeTB.Name = "LastAccessTimeTB";
            this.LastAccessTimeTB.Size = new System.Drawing.Size(209, 20);
            this.LastAccessTimeTB.TabIndex = 8;
            // 
            // FoldersListBox
            // 
            this.FoldersListBox.FormattingEnabled = true;
            this.FoldersListBox.Location = new System.Drawing.Point(244, 140);
            this.FoldersListBox.Name = "FoldersListBox";
            this.FoldersListBox.Size = new System.Drawing.Size(209, 212);
            this.FoldersListBox.TabIndex = 11;
            this.FoldersListBox.SelectedIndexChanged += new System.EventHandler(this.Folder_SelectedChange);
            // 
            // FileTypeLabelOption
            // 
            this.FileTypeLabelOption.AutoSize = true;
            this.FileTypeLabelOption.Location = new System.Drawing.Point(64, 29);
            this.FileTypeLabelOption.Name = "FileTypeLabelOption";
            this.FileTypeLabelOption.Size = new System.Drawing.Size(87, 13);
            this.FileTypeLabelOption.TabIndex = 12;
            this.FileTypeLabelOption.Text = "File Type Option:";
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(12, 140);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(209, 212);
            this.FilesListBox.TabIndex = 13;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(12, 121);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(31, 13);
            this.FileLabel.TabIndex = 14;
            this.FileLabel.Text = "Files:";
            // 
            // FolderLabel
            // 
            this.FolderLabel.AutoSize = true;
            this.FolderLabel.Location = new System.Drawing.Point(241, 121);
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Size = new System.Drawing.Size(44, 13);
            this.FolderLabel.TabIndex = 15;
            this.FolderLabel.Text = "Folders:";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(12, 375);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FileNameLabel.TabIndex = 16;
            this.FileNameLabel.Text = "File Name:";
            // 
            // FileNameTextbox
            // 
            this.FileNameTextbox.Enabled = false;
            this.FileNameTextbox.Location = new System.Drawing.Point(76, 375);
            this.FileNameTextbox.Name = "FileNameTextbox";
            this.FileNameTextbox.Size = new System.Drawing.Size(377, 20);
            this.FileNameTextbox.TabIndex = 17;
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Location = new System.Drawing.Point(241, 410);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(49, 13);
            this.FileSizeLabel.TabIndex = 18;
            this.FileSizeLabel.Text = "File Size:";
            // 
            // FileSizeTextbox
            // 
            this.FileSizeTextbox.Enabled = false;
            this.FileSizeTextbox.Location = new System.Drawing.Point(244, 435);
            this.FileSizeTextbox.Name = "FileSizeTextbox";
            this.FileSizeTextbox.Size = new System.Drawing.Size(209, 20);
            this.FileSizeTextbox.TabIndex = 19;
            // 
            // LastModLabel
            // 
            this.LastModLabel.AutoSize = true;
            this.LastModLabel.Location = new System.Drawing.Point(241, 470);
            this.LastModLabel.Name = "LastModLabel";
            this.LastModLabel.Size = new System.Drawing.Size(111, 13);
            this.LastModLabel.TabIndex = 20;
            this.LastModLabel.Text = "Last modification time:";
            // 
            // LastModTextbox
            // 
            this.LastModTextbox.Enabled = false;
            this.LastModTextbox.Location = new System.Drawing.Point(244, 495);
            this.LastModTextbox.Name = "LastModTextbox";
            this.LastModTextbox.Size = new System.Drawing.Size(209, 20);
            this.LastModTextbox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 528);
            this.Controls.Add(this.LastModTextbox);
            this.Controls.Add(this.LastModLabel);
            this.Controls.Add(this.FileSizeTextbox);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FileNameTextbox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FolderLabel);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.FileTypeLabelOption);
            this.Controls.Add(this.FoldersListBox);
            this.Controls.Add(this.LastAccessTimeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreationTimeTextbox);
            this.Controls.Add(this.CreationLabel);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.FileSystemLabel);
            this.Controls.Add(this.PathTextbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextbox;
        private System.Windows.Forms.Label FileSystemLabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RadioButton FileButton;
        private System.Windows.Forms.RadioButton FolderButton;
        private System.Windows.Forms.Label CreationLabel;
        private System.Windows.Forms.TextBox CreationTimeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastAccessTimeTB;
        private System.Windows.Forms.ListBox FoldersListBox;
        private System.Windows.Forms.Label FileTypeLabelOption;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label FolderLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextbox;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.TextBox FileSizeTextbox;
        private System.Windows.Forms.Label LastModLabel;
        private System.Windows.Forms.TextBox LastModTextbox;
    }
}

