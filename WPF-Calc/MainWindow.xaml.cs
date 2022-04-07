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

namespace WPF_Calc
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
        public double a = 0;
        public double b = 0;
        public int count = 0;

        public void Calculate()
        {
            if (rezultTextBox.Text != "" && calculationsTextBox.Text != "" || rezultTextBox.Text != null && calculationsTextBox != null)
            {
                switch (count)
                {
                    case 1:
                        b = a + double.Parse(rezultTextBox.Text);
                        rezultTextBox.Text = b.ToString();
                        break;
                    case 2:
                        b = a - double.Parse(rezultTextBox.Text);
                        rezultTextBox.Text = b.ToString();
                        break;
                    case 3:
                        b = a * double.Parse(rezultTextBox.Text);
                        rezultTextBox.Text = b.ToString();
                        break;
                    case 4:
                        b = a / double.Parse(rezultTextBox.Text);
                        rezultTextBox.Text = b.ToString();
                        break;

                    default:
                        break;
                }
            }
            else { rezultTextBox.Text = "Error"; }
        }

        private void oneBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "1";
            }
            else { rezultTextBox.Text += "1"; }
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "2";
            }
            else { rezultTextBox.Text += "2"; }
        }

        private void threeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "3";
            }
            else { rezultTextBox.Text += "3"; }
        }

        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "4";
            }
            else { rezultTextBox.Text += "4"; }
        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "5";
            }
            else { rezultTextBox.Text += "5"; }
        }

        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "6";
            }
            else { rezultTextBox.Text += "6"; }
        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "7";
            }
            else { rezultTextBox.Text += "7"; }
        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "8";
            }
            else { rezultTextBox.Text += "8"; }
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "9";
            }
            else { rezultTextBox.Text += "9"; }
        }

        private void zeroBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text = "0";
            }
            else { rezultTextBox.Text += "0"; }
        }

        private void dotBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rezultTextBox.Text == "0" && rezultTextBox != null)
            {
                rezultTextBox.Text += ",";
            }
            else { rezultTextBox.Text += ","; }
        }

        private void ceBtn_Click(object sender, RoutedEventArgs e)
        {
            rezultTextBox.Text = "0";
        }

        private void cBtn_Click(object sender, RoutedEventArgs e)
        {
            rezultTextBox.Text = "";
            calculationsTextBox.Text = "";
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int lenght = rezultTextBox.Text.Length - 1;
            string text = rezultTextBox.Text;
            rezultTextBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                rezultTextBox.Text = rezultTextBox.Text + text[i];
            }
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(rezultTextBox.Text);
            rezultTextBox.Clear();
            count = 1;
            calculationsTextBox.Text = a.ToString() + "+";
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(rezultTextBox.Text);
            rezultTextBox.Clear();
            count = 2;
            calculationsTextBox.Text = a.ToString() + "-";
        }

        private void multiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(rezultTextBox.Text);
            rezultTextBox.Clear();
            count = 3;
            calculationsTextBox.Text = a.ToString() + "*";
        }

        private void divideBtn_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(rezultTextBox.Text);
            rezultTextBox.Clear();
            count = 4;
            calculationsTextBox.Text = a.ToString() + "/";
        }

        private void equalBtn_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            calculationsTextBox.Text = "";
        }


    }
}
