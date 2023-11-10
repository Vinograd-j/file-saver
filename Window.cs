namespace file_saver
{
    public partial class FileSaver : Form
    {

        private readonly Reader _reader;

        private bool _isActive;

        public FileSaver()
        {
            InitializeComponent();

            _reader = new Reader();
        }

        private void OnMusicButtonClick(object sender, EventArgs e)
        {
            if (musicBrowserDialog.ShowDialog() == DialogResult.OK)
                _reader.MusicDirectory = musicBrowserDialog.SelectedPath;
        }

        private void OnVideoButtonClick(object sender, EventArgs e)
        {
            if (videoBrowserDialog.ShowDialog() == DialogResult.OK)
                _reader.VideoDirectory = videoBrowserDialog.SelectedPath;
        }

        private void OnArchiveButtonClick(object sender, EventArgs e)
        {
            if (archiveBrowserDialog.ShowDialog() == DialogResult.OK)
                _reader.ArchiveDirectory = archiveBrowserDialog.SelectedPath;
        }

        private void OnEnableButtonClick(object sender, EventArgs e)
        {
            if (!_isActive)
            {

                if (!CheckParameters())
                    return;

                _reader.StartReading();
                EnableButton.Text = "Выключить";

            }
            else
            {
                _reader.StopReading();
                EnableButton.Text = "Включить";
            }

            ChangeButtonsState();

            _isActive = !_isActive;

        }

        private void ChangeButtonsState()
        {
            MusicFolderButton.Enabled = !MusicFolderButton.Enabled;
            VideoFolderButton.Enabled = !VideoFolderButton.Enabled;
            ArchiveFolderButton.Enabled = !ArchiveFolderButton.Enabled;
            SourceDirectoryButton.Enabled = !SourceDirectoryButton.Enabled;
        }

        private bool CheckParameters()
        {
            if (_reader.ArchiveDirectory == null || _reader.SourceDirectory == null || _reader.VideoDirectory == null || _reader.MusicDirectory == null)
            {
                Exception.Visible = true;

                return false;
            }

            if (Exception.Visible)
                Exception.Visible = false;

            return true;
        }


        private void OnSourceDirectoryButtonClick(object sender, EventArgs e)
        {
            if (sourceBrowserDialog.ShowDialog() == DialogResult.OK)
                _reader.ChangeSourceDirectory(sourceBrowserDialog.SelectedPath);

        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            _reader.StopReading();
        }
    }
}