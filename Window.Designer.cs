namespace file_saver
{
    partial class FileSaver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MusicFolderButton = new Button();
            VideoFolderButton = new Button();
            ArchiveFolderButton = new Button();
            EnableButton = new Button();
            musicBrowserDialog = new FolderBrowserDialog();
            videoBrowserDialog = new FolderBrowserDialog();
            archiveBrowserDialog = new FolderBrowserDialog();
            SourceDirectoryButton = new Button();
            sourceBrowserDialog = new FolderBrowserDialog();
            Exception = new Label();
            SuspendLayout();
            // 
            // MusicFolderButton
            // 
            MusicFolderButton.Location = new Point(224, 12);
            MusicFolderButton.Name = "MusicFolderButton";
            MusicFolderButton.Size = new Size(173, 23);
            MusicFolderButton.TabIndex = 1;
            MusicFolderButton.Text = "Music Folder";
            MusicFolderButton.UseVisualStyleBackColor = true;
            MusicFolderButton.Click += OnMusicButtonClick;
            // 
            // VideoFolderButton
            // 
            VideoFolderButton.Location = new Point(224, 56);
            VideoFolderButton.Name = "VideoFolderButton";
            VideoFolderButton.Size = new Size(173, 23);
            VideoFolderButton.TabIndex = 2;
            VideoFolderButton.Text = "Video Folder";
            VideoFolderButton.UseVisualStyleBackColor = true;
            VideoFolderButton.Click += OnVideoButtonClick;
            // 
            // ArchiveFolderButton
            // 
            ArchiveFolderButton.Location = new Point(224, 102);
            ArchiveFolderButton.Name = "ArchiveFolderButton";
            ArchiveFolderButton.Size = new Size(173, 23);
            ArchiveFolderButton.TabIndex = 3;
            ArchiveFolderButton.Text = "Archive Folder";
            ArchiveFolderButton.UseVisualStyleBackColor = true;
            ArchiveFolderButton.Click += OnArchiveButtonClick;
            // 
            // EnableButton
            // 
            EnableButton.Location = new Point(255, 146);
            EnableButton.Name = "EnableButton";
            EnableButton.Size = new Size(107, 35);
            EnableButton.TabIndex = 4;
            EnableButton.Text = "Enable";
            EnableButton.UseVisualStyleBackColor = true;
            EnableButton.Click += OnEnableButtonClick;
            // 
            // SourceDirectoryButton
            // 
            SourceDirectoryButton.Location = new Point(26, 13);
            SourceDirectoryButton.Name = "SourceDirectoryButton";
            SourceDirectoryButton.Size = new Size(117, 23);
            SourceDirectoryButton.TabIndex = 5;
            SourceDirectoryButton.Text = "Source Directory";
            SourceDirectoryButton.UseVisualStyleBackColor = true;
            SourceDirectoryButton.Click += OnSourceDirectoryButtonClick;
            // 
            // Exception
            // 
            Exception.AutoSize = true;
            Exception.Location = new Point(131, 209);
            Exception.Name = "Exception";
            Exception.Size = new Size(342, 15);
            Exception.TabIndex = 6;
            Exception.Text = "Error! Some parameters are not specified! Startup is not possible";
            Exception.Visible = false;
            // 
            // FileSaver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 257);
            Controls.Add(Exception);
            Controls.Add(SourceDirectoryButton);
            Controls.Add(EnableButton);
            Controls.Add(ArchiveFolderButton);
            Controls.Add(VideoFolderButton);
            Controls.Add(MusicFolderButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FileSaver";
            Text = "FileSaver";
            FormClosing += OnFormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button MusicFolderButton;
        private Button VideoFolderButton;
        private Button ArchiveFolderButton;
        private Button EnableButton;
        private FolderBrowserDialog musicBrowserDialog;
        private FolderBrowserDialog videoBrowserDialog;
        private FolderBrowserDialog archiveBrowserDialog;
        private Button SourceDirectoryButton;
        private FolderBrowserDialog sourceBrowserDialog;
        private Label Exception;
    }
}