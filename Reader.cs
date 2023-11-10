namespace file_saver
{
    internal class Reader
    {

        private FileSystemWatcher _watcher;

        public string? SourceDirectory { get; private set; }


        public string? MusicDirectory { get; set; }
        public string? VideoDirectory { get; set; }
        public string? ArchiveDirectory { get; set; }


        public Reader()
        {
            _watcher = new FileSystemWatcher
            {
                NotifyFilter = NotifyFilters.FileName,
                Filter = "*.*",
            };

        }

        public void StartReading()
        {
            _watcher.EnableRaisingEvents = true;
            _watcher.Created += OnFileCreated;
        }

        public void StopReading()
        {
            _watcher.EnableRaisingEvents = false;
            _watcher.Created -= OnFileCreated;
        }

        private void OnFileCreated(object sender, FileSystemEventArgs e)
        {

            string? fileName = e.Name;
            string? extension = Path.GetExtension(fileName);

            switch (extension)
            {
                case ".wav":
                case ".mp3":
                    File.Move(SourceDirectory + "/" + fileName, MusicDirectory + "/" + fileName);
                    break;

                case ".mp4":
                case "mov":
                    File.Move(SourceDirectory + "/" + fileName, VideoDirectory + "/" + fileName);
                    break;

                case ".zip":
                case ".rar":
                    File.Move(SourceDirectory + "/" + fileName, ArchiveDirectory + "/" + fileName);
                    break;

            }

        }

        public void ChangeSourceDirectory(string path)
        {
            SourceDirectory = path;
            _watcher.Path = SourceDirectory;
        }



    }
}
