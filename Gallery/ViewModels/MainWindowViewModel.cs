namespace TreeDataGridDemo.ViewModels
{
    internal class MainWindowViewModel
    {
        private FilesPageViewModel? _files;

        public FilesPageViewModel Files
        {
            get => _files ??= new FilesPageViewModel();
        }
    }
}
