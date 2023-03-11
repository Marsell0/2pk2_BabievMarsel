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

namespace pz_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "0";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "+";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "-";
        }

        private void btn_mult_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "*";
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            infoTextBox.Text += "/";
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            string info = infoTextBox.Text;
            infoTextBox.Text = Calculate(info).ToString();
        }
        private double Calculate(string info)
        {

        }
    }
}
