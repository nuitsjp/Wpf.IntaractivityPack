using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using Microsoft.Win32;

namespace Wpf.Intaractivity
{
    public abstract class FileDialogAction : TriggerAction<DependencyObject>
    {
        public static readonly DependencyProperty AddExtensionProperty = DependencyProperty.Register(
            "AddExtension", typeof(bool), typeof(FileDialogAction), new PropertyMetadata(default(bool)));

        public bool AddExtension
        {
            // ReSharper disable once PossibleNullReferenceException
            get => (bool)GetValue(AddExtensionProperty);
            set => SetValue(AddExtensionProperty, value);
        }

        public static readonly DependencyProperty CheckFileExistsProperty = DependencyProperty.Register(
            "CheckFileExists", typeof(bool), typeof(FileDialogAction), new PropertyMetadata(default(bool)));

        public bool CheckFileExists
        {
            // ReSharper disable once PossibleNullReferenceException
            get => (bool)GetValue(CheckFileExistsProperty);
            set => SetValue(CheckFileExistsProperty, value);
        }

        public static readonly DependencyProperty CheckPathExistsProperty = DependencyProperty.Register(
            "CheckPathExists", typeof(bool), typeof(FileDialogAction), new PropertyMetadata(default(bool)));

        public bool CheckPathExists
        {
            // ReSharper disable once PossibleNullReferenceException
            get => (bool)GetValue(CheckPathExistsProperty);
            set => SetValue(CheckPathExistsProperty, value);
        }

        public static readonly DependencyProperty CustomPlacesProperty = DependencyProperty.Register(
            "CustomPlaces", typeof(IList<FileDialogCustomPlace>), typeof(FileDialogAction), new PropertyMetadata(default(IList<FileDialogCustomPlace>)));

        public IList<FileDialogCustomPlace> CustomPlaces
        {
            get => (IList<FileDialogCustomPlace>)GetValue(CustomPlacesProperty);
            set => SetValue(CustomPlacesProperty, value);
        }

        public static readonly DependencyProperty DefaultExtProperty = DependencyProperty.Register(
            "DefaultExt", typeof(string), typeof(FileDialogAction), new PropertyMetadata(default(string)));

        public string DefaultExt
        {
            get => (string)GetValue(DefaultExtProperty);
            set => SetValue(DefaultExtProperty, value);
        }

        public static readonly DependencyProperty DereferenceLinksProperty = DependencyProperty.Register(
            "DereferenceLinks", typeof(bool), typeof(FileDialogAction), new PropertyMetadata(default(bool)));

        public bool DereferenceLinks
        {
            // ReSharper disable once PossibleNullReferenceException
            get => (bool)GetValue(DereferenceLinksProperty);
            set => SetValue(DereferenceLinksProperty, value);
        }

        public static readonly DependencyProperty FilterProperty = DependencyProperty.Register(
            "Filter", typeof(string), typeof(FileDialogAction), new PropertyMetadata(default(string)));

        public string Filter
        {
            get => (string)GetValue(FilterProperty);
            set => SetValue(FilterProperty, value);
        }

        public static readonly DependencyProperty FilterIndexProperty = DependencyProperty.Register(
            "FilterIndex", typeof(int), typeof(FileDialogAction), new PropertyMetadata(default(int)));

        public int FilterIndex
        {
            // ReSharper disable once PossibleNullReferenceException
            get => (int)GetValue(FilterIndexProperty);
            set => SetValue(FilterIndexProperty, value);
        }

        public static readonly DependencyProperty InitialDirectoryProperty = DependencyProperty.Register(
            "InitialDirectory", typeof(string), typeof(FileDialogAction), new PropertyMetadata(default(string)));

        public string InitialDirectory
        {
            get => (string)GetValue(InitialDirectoryProperty);
            set => SetValue(InitialDirectoryProperty, value);
        }

        public static readonly DependencyProperty TagProperty = DependencyProperty.Register(
            "Tag", typeof(object), typeof(FileDialogAction), new PropertyMetadata(default(object)));

        public object Tag
        {
            get => GetValue(TagProperty);
            set => SetValue(TagProperty, value);
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title", typeof(string), typeof(FileDialogAction), new PropertyMetadata(default(string)));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty ValidateNamesProperty = DependencyProperty.Register(
            "ValidateNames", typeof(bool), typeof(FileDialogAction), new PropertyMetadata(default(bool)));

        public bool ValidateNames
        {
            // ReSharper disable once PossibleNullReferenceException
            get => (bool)GetValue(ValidateNamesProperty);
            set => SetValue(ValidateNamesProperty, value);
        }

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command", typeof(ICommand), typeof(FileDialogAction), new PropertyMetadata(default(ICommand)));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public static readonly DependencyProperty CancelCommandProperty = DependencyProperty.Register(
            "CancelCommand", typeof(ICommand), typeof(FileDialogAction), new PropertyMetadata(default(ICommand)));

        public ICommand CancelCommand
        {
            get => (ICommand)GetValue(CancelCommandProperty);
            set => SetValue(CancelCommandProperty, value);
        }
    }
}
