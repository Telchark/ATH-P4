using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileContent fileContent = new FileContent();
        private FileSystemWatcher fileWatcher = new FileSystemWatcher();
        public MainWindow()
        {
            InitializeComponent();
            TB.DataContext = fileContent;
            fileWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileWatcher.Changed += watcherReaction;
        }
        /// <summary>
        /// Paczacz paczy i co sie dzieje jak zobaczy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void watcherReaction(object sender, FileSystemEventArgs e)
        {
            var txt = File.ReadAllText(fileContent.Path);
            fileContent.Content = txt;
        }
        /// <summary>
        /// Wczytanie pliku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Wybierz plik",
                Filter="Textfile|*.txt"
            };
            var getFile = fileDialog.ShowDialog(this);
            if(getFile.HasValue || getFile.Value)
            {
                fileContent.Path = fileDialog.FileName;
                fileWatcher.Path = fileDialog.FileName.Replace(fileDialog.SafeFileName, string.Empty);
                fileWatcher.EnableRaisingEvents = true;
                var txt = File.ReadAllText(fileContent.Path);
                fileContent.Content = txt;
            }
        }
        /// <summary>
        /// Zawartość pliku z kontrolą czy nie zapisujemy tego samego
        /// </summary>
        public class FileContent : INotifyPropertyChanged
        {
            public string Path { get; set; }
            private string _content;
            public string Content
            {
                get { return _content; }
                set
                {
                    if (_content != value)
                    {
                        _content = value;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Content"));
                    }
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}
