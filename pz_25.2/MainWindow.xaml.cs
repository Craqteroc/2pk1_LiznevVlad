using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Calc
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

        private void Press5Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "5";
        }

        private void PressButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "7";
        }

        private void Press3Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "8";
        }

        private void Press4Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "9";
        }

        private void Press9Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
        }

        private void Press1Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "4";
        }

        private void Press6Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "6";
        }

        private void Press10Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
        }

        private void Press2Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "1";
        }

        private void Press7Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "2";
        }

        private void Press8Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "3";
        }

        private void Press11Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
        }

        private void Press13Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "0";
        }

        private void Press14Button_Click(object sender, RoutedEventArgs e)
        {
            string exp = inputTextBlock.Text;
            inputTextBlock.Text = calc(exp).ToString();

            //try
            //{
            //    calc(exp);
            //}
            //catch (Exception exc)
            //{
            //    inputTextBlock.Text = "Error!";
            //}
        }

        private double calc(string exp)
        {
            Regex regex = new Regex(@"^\d(\w*).(\w*)\d(\w*)");

            MatchCollection matches = regex.Matches(exp);

            //if (matches[1].ToString() == "+")
            //{
                
            //    string res = matches[0] + matches[2];
            //}

            return 0;
        }
            

            private void Press12Button_Click(object sender, RoutedEventArgs e)
            {
                inputTextBlock.Text += "/";
            }
        }
    }


