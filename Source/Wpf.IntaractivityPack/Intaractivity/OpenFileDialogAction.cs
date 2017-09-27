using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using Microsoft.Win32;

namespace Wpf.Intaractivity
{
    public class OpenFileDialogAction : FileDialogAction
    {
        public static IOpenFileDialogServiceFactory DefaultOpenFileDialogServiceFactory { get; } = new OpenFileDialogServiceFactory();

        public static readonly DependencyProperty OpenFileDialogServiceFactoryProperty = DependencyProperty.Register(
            "OpenFileDialogServiceFactory", typeof(IOpenFileDialogServiceFactory), typeof(OpenFileDialogAction), new PropertyMetadata(DefaultOpenFileDialogServiceFactory));

        public IOpenFileDialogServiceFactory OpenFileDialogServiceFactory
        {
            get => (IOpenFileDialogServiceFactory) GetValue(OpenFileDialogServiceFactoryProperty);
            set => SetValue(OpenFileDialogServiceFactoryProperty, value);
        }

        public static readonly DependencyProperty FileNameProperty = DependencyProperty.Register(
            "FileName", typeof(string), typeof(OpenFileDialogAction), new FrameworkPropertyMetadata(default(string)) { BindsTwoWayByDefault = true });

        public string FileName
        {
            get => (string) GetValue(FileNameProperty);
            set => SetValue(FileNameProperty, value);
        }

        public static readonly DependencyProperty SafeFileNameProperty = DependencyProperty.Register(
            "SafeFileName", typeof(string), typeof(OpenFileDialogAction), new FrameworkPropertyMetadata(default(string)) { BindsTwoWayByDefault = true });

        public string SafeFileName
        {
            get => (string) GetValue(SafeFileNameProperty);
            set => SetValue(SafeFileNameProperty, value);
        }

        protected override void Invoke(object parameter)
        {
            var openFileDialogService = OpenFileDialogServiceFactory.Create();
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
                FileName = openFileDialogService.FileName;
                SafeFileName = openFileDialogService.SafeFileName;
                if (Command != null && Command.CanExecute(openFileDialogService.FileName))
                {
                    Command.Execute(openFileDialogService.FileName);
                }
            }
            else
            {
                if (CancelCommand != null && CancelCommand.CanExecute(openFileDialogService.FileName))
                    CancelCommand.Execute(null);
            }
        }
    }
}
