using StudentCardLibrary;
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

namespace StudentCard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> stds = new ObservableCollection<Student>();
        public MainWindow()
        {
            InitializeComponent();
            StudentsList.ItemsSource = stds;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            addStudent.AddStd += (std) =>{stds.Add(std);};

        }
    }
}
