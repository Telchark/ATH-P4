using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab9
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var view = new StudentView();
            this.DataContext = view;
            LB1.ItemsSource = view.List.students;
        }

    }
    /// <summary>
    /// Studenciak
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => Name +" " + LastName;
        public DateTime Enlisting { get; set; }
        public override string ToString()
        {
            return FullName;
        }
    }
    public class StudentList
    {
        public ObservableCollection<Student> students { get; set; }
    }

    public class StudentView
    {
        public StudentList List { get; set; }
        public StudentView()
        {
            List = new StudentList()
            {
                students = new ObservableCollection<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Andrzej",
                    LastName = "Boba",
                    Enlisting = new DateTime(1998, 1, 1)
                },
                new Student
                {
                    Id = 2,
                    Name = "Jan",
                    LastName = "Kowalski",
                    Enlisting = new DateTime(2002, 1, 1)
                },
                new Student
                {
                    Id = 3,
                    Name = "Genowefa",
                    LastName = "Konstantynopolitańczykiewiczówna",
                    Enlisting = new DateTime(1970, 1, 1)
                }
            }
            };
    }
}

}
