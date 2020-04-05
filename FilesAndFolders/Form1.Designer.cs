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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FilePathTextbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PathTextbox
            // 
            this.PathTextbox.Location = new System.Drawing.Point(180, 95);
            this.PathTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.Size = new System.Drawing.Size(206, 20);
            this.PathTextbox.TabIndex = 0;
            // 
            // FileSystemLabel
            // 
            this.FileSystemLabel.AutoSize = true;
            this.FileSystemLabel.Location = new System.Drawing.Point(60, 98);
            this.FileSystemLabel.Name = "FileSystemLabel";
            this.FileSystemLabel.Size = new System.Drawing.Size(115, 13);
            this.FileSystemLabel.TabIndex = 1;
            this.FileSystemLabel.Text = "Enter your file or folder:";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(180, 146);
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
            this.FileButton.Location = new System.Drawing.Point(125, 56);
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
            this.FolderButton.Location = new System.Drawing.Point(201, 56);
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
            this.CreationLabel.Location = new System.Drawing.Point(49, 195);
            this.CreationLabel.Name = "CreationLabel";
            this.CreationLabel.Size = new System.Drawing.Size(75, 13);
            this.CreationLabel.TabIndex = 5;
            this.CreationLabel.Text = "Creation Time:";
            // 
            // CreationTimeTextbox
            // 
            this.CreationTimeTextbox.Enabled = false;
            this.CreationTimeTextbox.Location = new System.Drawing.Point(52, 222);
            this.CreationTimeTextbox.Name = "CreationTimeTextbox";
            this.CreationTimeTextbox.Size = new System.Drawing.Size(139, 20);
            this.CreationTimeTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Access Time:";
            // 
            // LastAccessTimeTB
            // 
            this.LastAccessTimeTB.Enabled = false;
            this.LastAccessTimeTB.Location = new System.Drawing.Point(218, 222);
            this.LastAccessTimeTB.Name = "LastAccessTimeTB";
            this.LastAccessTimeTB.Size = new System.Drawing.Size(144, 20);
            this.LastAccessTimeTB.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 9;
            // 
            // FilePathTextbox
            // 
            this.FilePathTextbox.AutoSize = true;
            this.FilePathTextbox.Location = new System.Drawing.Point(191, 261);
            this.FilePathTextbox.Name = "FilePathTextbox";
            this.FilePathTextbox.Size = new System.Drawing.Size(51, 13);
            this.FilePathTextbox.TabIndex = 10;
            this.FilePathTextbox.Text = "File Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 414);
            this.Controls.Add(this.FilePathTextbox);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label FilePathTextbox;
    }
}

