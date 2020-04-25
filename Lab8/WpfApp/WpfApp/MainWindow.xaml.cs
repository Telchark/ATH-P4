using System;
using System.Collections.Generic;
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
        public int answersCount = 0;
        Dictionary<string, int> certainAnswerCounter = new Dictionary<string, int>()
        {
            { "A",0 },
            { "B",0 },
            { "C",0 },
            { "D",0 },
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var choice = btn.Content.ToString();

            certainAnswerCounter[choice]++;

            lblAllAnswersCount.Content = $"Ilość odpowiedzi {(++answersCount).ToString()}";
            lblBestAnswer.Content = $"Ilość najlepszej odpowiedzi {certainAnswerCounter.Max(n=>n.Value)}";
            BA.Height = Canvas.ActualHeight * (certainAnswerCounter["A"] / (double)answersCount);
            BB.Height = Canvas.ActualHeight * (certainAnswerCounter["B"] / (double)answersCount);
            BC.Height = Canvas.ActualHeight * (certainAnswerCounter["C"] / (double)answersCount);
            BD.Height = Canvas.ActualHeight * (certainAnswerCounter["D"] / (double)answersCount);
        }
    }
}
