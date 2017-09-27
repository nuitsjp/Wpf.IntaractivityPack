using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Reactive.Bindings;
using Microsoft.Win32;

namespace Wpf.IntaractivityPack.Sample.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public bool AddExtension { get; set; } = true;

        public bool CheckFileExists { get; set; } = true;

        public bool CheckPathExists { get; set; }

        public IList<FileDialogCustomPlace> CustomPlaces { get; set; } = new List<FileDialogCustomPlace>();

        public string DefaultExt { get; set; } = string.Empty;

        public bool DereferenceLinks { get; set; } = false;

        public string Filter { get; set; } = string.Empty;

        public int FilterIndex { get; set; } = 1;

        public string InitialDirectory { get; set; } = string.Empty;

        public object Tag { get; set; }

        public string Title { get; set; } = "ファイル選択ダイアログタイトル";

        public string OpenFilesTitle { get; set; } = "複数ファイル選択ダイアログタイトル";

        public bool ValidateNames { get; set; }

        private string _filePath;
        private string[] _filePaths;

        public string FilePath
        {
            get => _filePath;
            set => SetProperty(ref _filePath, value);
        }

        public string[] FilePaths
        {
            get => _filePaths;
            set => SetProperty(ref _filePaths, value);
        }

        public string SafeFileName { get; set; }


        public ReactiveCommand<string> SelectedFileCommand { get; }

        public MainWindowViewModel()
        {
            SelectedFileCommand = new ReactiveCommand<string>();
            SelectedFileCommand.Subscribe(filePath =>
            {
                FilePath = filePath;
            });
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if(Equals(field, value)) return false;

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
        #endregion
    }
}
