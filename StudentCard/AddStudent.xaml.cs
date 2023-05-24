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
using System.Windows.Shapes;
using StudentCardLibrary;

namespace StudentCard
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void NewStudent(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] fio = FIO_tb.Text.Split(" ");
                Student std = new Student(fio[0], fio[1], fio[2], Convert.ToDateTime(BDay_dp.Text), Group_tb.Text, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
