using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Wpf.Intaractivity
{
    public class OpenFileDialogAction : TriggerAction<DependencyObject>
    {
        public static readonly IOpenFileDialogService DefaultOpenFileDialogService = new OpenFileDialogService();

        public static readonly DependencyProperty OpenFileDialogServiceProperty = DependencyProperty.Register(
            "OpenFileDialogService", typeof(IOpenFileDialogService), typeof(OpenFileDialogAction), new PropertyMetadata(DefaultOpenFileDialogService));

        public IOpenFileDialogService OpenFileDialogService
        {
            get => (IOpenFileDialogService) GetValue(OpenFileDialogServiceProperty);
            set => SetValue(OpenFileDialogServiceProperty, value);
        }

        public static readonly DependencyProperty SelectedFileNameProperty = DependencyProperty.Register(
            "SelectedFileName", typeof(string), typeof(OpenFileDialogAction),
            new FrameworkPropertyMetadata(default(string)) {BindsTwoWayByDefault = true});

        public string SelectedFileName
        {
            get => (string) GetValue(SelectedFileNameProperty);
            set => SetValue(SelectedFileNameProperty, value);
        }

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command", typeof(ICommand), typeof(OpenFileDialogAction), new PropertyMetadata(default(ICommand)));

        public ICommand Command
        {
            get => (ICommand) GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public static readonly DependencyProperty CancelCommandProperty = DependencyProperty.Register(
            "CancelCommand", typeof(ICommand), typeof(OpenFileDialogAction), new PropertyMetadata(default(ICommand)));

        public ICommand CancelCommand
        {
            get => (ICommand) GetValue(CancelCommandProperty);
            set => SetValue(CancelCommandProperty, value);
        }

        protected override void Invoke(object parameter)
        {
            if (OpenFileDialogService.ShowDialog())
            {
                if (Command == null)
                {
                    SelectedFileName = OpenFileDialogService.FileName;
                }
                else if (Command.CanExecute(OpenFileDialogService.FileName))
                {
                    Command.Execute(OpenFileDialogService.FileName);
                }
            }
            else
            {
                if (CancelCommand != null && CancelCommand.CanExecute(OpenFileDialogService.FileName))
                    CancelCommand.Execute(null);
            }
        }
    }
}
