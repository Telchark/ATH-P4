using MapDemo.UI.ViewModel;
using System.Windows;

namespace MapDemo.UI
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }

        private void WeaponMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Tab.SelectedIndex = 0;
        }
        private void ArmorMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Tab.SelectedIndex = 1;
        }
        private void ResourceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Tab.SelectedIndex = 2;
        }
        private void CastleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Tab.SelectedIndex = 3;
        }
    }
}
