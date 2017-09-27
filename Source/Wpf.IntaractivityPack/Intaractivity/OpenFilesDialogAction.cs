using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using Microsoft.Win32;

namespace Wpf.Intaractivity
{
    public class OpenFilesDialogAction : FileDialogAction
    {
        public static IOpenFilesDialogServiceFactory DefaultOpenFilesDialogServiceFactory { get; } = new OpenFilesDialogServiceFactory();

        public static readonly DependencyProperty OpenFileDialogServiceFactoryProperty = DependencyProperty.Register(
            "OpenFileDialogServiceFactory", typeof(IOpenFilesDialogServiceFactory), typeof(OpenFilesDialogAction), new PropertyMetadata(DefaultOpenFilesDialogServiceFactory));

        public IOpenFilesDialogServiceFactory OpenFilesDialogServiceFactory
        {
            get => (IOpenFilesDialogServiceFactory) GetValue(OpenFileDialogServiceFactoryProperty);
            set => SetValue(OpenFileDialogServiceFactoryProperty, value);
        }

        public static readonly DependencyProperty FileNamesProperty = DependencyProperty.Register(
            "FileNames", typeof(string[]), typeof(OpenFilesDialogAction), new FrameworkPropertyMetadata(default(string[])) { BindsTwoWayByDefault = true});

        public string[] FileNames
        {
            get => (string[]) GetValue(FileNamesProperty);
            set => SetValue(FileNamesProperty, value);
        }

        public static readonly DependencyProperty SafeFileNamesProperty = DependencyProperty.Register(
            "SafeFileNames", typeof(string[]), typeof(OpenFilesDialogAction), new FrameworkPropertyMetadata(default(string[])) { BindsTwoWayByDefault = true });

        public string[] SafeFileNames
        {
            get => (string[]) GetValue(SafeFileNamesProperty);
            set => SetValue(SafeFileNamesProperty, value);
        }

        protected override void Invoke(object parameter)
        {
            var openFileDialogService = OpenFilesDialogServiceFactory.Create();
            openFileDialogService.AddExtension = AddExtension;
            openFileDialogService.CheckFileExists = CheckFileExists;
            openFileDialogService.CheckPathExists = CheckPathExists;
            openFileDialogService.CustomPlaces = CustomPlaces;
            openFileDialogService.DefaultExt = DefaultExt;
            openFileDialogService.DereferenceLinks = DereferenceLinks;
            openFileDialogService.Filter = Filter;
            openFileDialogService.FilterIndex = FilterIndex;
            openFileDialogService.InitialDirectory = InitialDirectory;
            openFileDialogService.Tag = Tag;
            openFileDialogService.Title = Title;
            openFileDialogService.ValidateNames = ValidateNames;

            if (openFileDialogService.ShowDialog())
            {
                FileNames = openFileDialogService.FileNames;
                SafeFileNames = openFileDialogService.SafeFileNames;
                if (Command != null && Command.CanExecute(openFileDialogService.FileNames))
                {
                    Command.Execute(openFileDialogService.FileNames);
                }
            }
            else
            {
                if (CancelCommand != null && CancelCommand.CanExecute(null))
                    CancelCommand.Execute(null);
            }
        }
    }
}
