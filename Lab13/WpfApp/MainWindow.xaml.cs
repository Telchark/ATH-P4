using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IPanelFiller _panelFiller { get; private set; }
        private MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(IPanelFiller panelFiller) : this()
        {
            _panelFiller = panelFiller;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _panelFiller.Fill(Panel);
        }
    }
}
