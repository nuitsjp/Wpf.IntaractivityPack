using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Reactive.Bindings;

namespace Wpf.IntaractivityPack.Sample.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _filePath;

        public string FilePath
        {
            get => _filePath;
            set => SetProperty(ref _filePath, value);
        }

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
