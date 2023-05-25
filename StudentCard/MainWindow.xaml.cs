using StudentCardLibrary;
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
            StorageInJson des = new StorageInJson("saves/stds.json");
            stds = des.Deserialize();
            StudentsList.ItemsSource = stds;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            addStudent.AddStd += (std) =>
            {
                stds.Add(std);
            };

            StorageInJson serialize = new StorageInJson(stds, "saves/stds.json");
            serialize.Serialize();
            StudentsList.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
            StudentsList.Items.Refresh();
        }
        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                stds.RemoveAt(StudentsList.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
