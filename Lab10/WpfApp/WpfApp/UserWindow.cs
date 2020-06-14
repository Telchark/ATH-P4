using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WpfApp
{
    public partial class UserWindow : Window
    {
        private ObservableCollection<User> _users = new ObservableCollection<User>();
        public UserWindow()
        {
            InitializeComponent();
            List.ItemsSource = _users;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var counter = 1;
            if (_users.Any())
            {
                counter = _users.Max(x => x?.Id + 1 ?? 1);
            }
            _users.Add(new User(
                counter,
                $"user{counter}",
                $"passwd{counter}",
                0));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_users.Any())
            {
                var user = _users[0];
                user.Points += 1;
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (_users.Any())
            {
                _users.RemoveAt(0);
            }
        }
    }
    //------------------------------------------------------------------------------------------
    class User : INotifyPropertyChanged
    {
        private int _points;

        public User(int id, string login, string pass, int points)
        {
            Id = id;
            Login = login;
            Password = pass;
            Points = points;
        }

        public int Points
        {
            get { return _points; }
            set
            {
                if (_points != value)
                {
                    _points = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Points"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
