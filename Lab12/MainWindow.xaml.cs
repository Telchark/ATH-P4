using System;
using System.IO;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace WpfAppLab12
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml 19.05.2020
    /// </summary>
    public partial class MainWindow : Window
    {
        public Model Model { get; set; } = new Model();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Model;
        }

        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            var test = this.FindResource("Title");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Brush"] = new SolidColorBrush(Colors.DarkMagenta);
            var res = new ResourceDictionary();
            res.Add("test", "test");
            Resources.MergedDictionaries.Add(res);
        }

        private void DynamicLoadStyles()
        {
            string file = Environment.CurrentDirectory + @"\Dictionary3.xaml";
            if (File.Exists(file))
            {
                using (FileStream fStream = new FileStream(file, FileMode.Open))
                {
                    ResourceDictionary dic = (ResourceDictionary)XamlReader.Load(fStream);
                    Resources.MergedDictionaries.Add(dic);
                }
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            DynamicLoadStyles();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Model.Zoom += 5;
        }
    }
}
