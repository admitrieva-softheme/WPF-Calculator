using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox1.Text = def;
            numberOne = 0.0;
            numberTwo = 0.0;
            answer = 0.0;
            first = true;
            complete = false;
            buffer = "";
            op = 0;
        }

        string def = "0.0";

        string buffer;

        double numberOne;
        double numberTwo;
        double answer;
        bool first;
        bool complete;
        int op;


        private void one_Click(object sender, RoutedEventArgs e)
        {
            buffer += "1";
            textBox1.Text = buffer;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            buffer += "2";
            textBox1.Text = buffer;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            buffer += "3";
            textBox1.Text = buffer;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            buffer += "4";
            textBox1.Text = buffer;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            buffer += "5";
            textBox1.Text = buffer;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            buffer += "6";
            textBox1.Text = buffer;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            buffer += "7";
            textBox1.Text = buffer;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            buffer += "8";
            textBox1.Text = buffer;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            buffer += "9";
            textBox1.Text = buffer;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            buffer += "0";
            textBox1.Text = buffer;
        }

        private void decipoint_Click(object sender, RoutedEventArgs e)
        {
            buffer += ".";
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (op != 0)
            {
                string str = "";
                buffer = checkDecimal(buffer);
                numberTwo = Convert.ToDouble(buffer);
                first = false;
                switch (op)
                {
                    case 1:
                        answer = numberOne + numberTwo;
                        str = Convert.ToString(numberOne) + "+" + Convert.ToString(numberTwo) + "=" + Convert.ToString(answer);
                        break;
                    case 2:
                        answer = numberOne - numberTwo;
                        str = Convert.ToString(numberOne) + "-" + Convert.ToString(numberTwo) + "=" + Convert.ToString(answer);
                        break;
                    case 3:
                        answer = numberOne * numberTwo;
                        str = Convert.ToString(numberOne) + "x" + Convert.ToString(numberTwo) + "=" + Convert.ToString(answer);
                        break;
                    case 4:
                        answer = numberOne / numberTwo;
                        str = Convert.ToString(numberOne) + "%" + Convert.ToString(numberTwo) + "=" + Convert.ToString(answer);
                        break;
                }
                buffer = string.Empty;
                textBox1.Text = Convert.ToString(answer);
                op = 0;
                listBox1.Items.Add(str);
            }
        }

        private void sign_Click(object sender, RoutedEventArgs e)
        {
            if (buffer.Length > 0)
            {
                if (buffer[0] == '-')
                {
                    buffer = buffer.Substring(1, buffer.Length - 1);
                }
                else
                {
                    buffer = "-" + buffer;
                }
            }
            else
            {
                buffer = "-" + buffer;
            }
            textBox1.Text = Convert.ToString(buffer);
        }

        private void clearentry_Click(object sender, RoutedEventArgs e)
        {
            buffer = "";
            textBox1.Text = def;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            buffer = "";
            op = 0;
            first = true;
            complete = false;
            textBox1.Text = def;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (first == false)
            {
                numberOne = answer;
                op = 1;
            }
            else
            {
                op = 1;
                buffer = checkDecimal(buffer);
                numberOne = Convert.ToDouble(buffer);
                buffer = string.Empty;
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (first == false)
            {
                numberOne = answer;
                op = 2;
            }
            else
            {
                op = 2;
                buffer = checkDecimal(buffer);
                numberOne = Convert.ToDouble(buffer);
                buffer = string.Empty;
            }
        }

        private void multiple_Click(object sender, RoutedEventArgs e)
        {
            if (first == false)
            {
                numberOne = answer;
                op = 3;
            }
            else
            {
                op = 3;
                buffer = checkDecimal(buffer);
                numberOne = Convert.ToDouble(buffer);
                buffer = string.Empty;
            }

        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if (first == false)
            {
                numberOne = answer;
                op = 4;
            }
            else
            {
                op = 4;
                buffer = checkDecimal(buffer);
                numberOne = Convert.ToDouble(buffer);
                buffer = string.Empty;
            }
        }

        private string checkDecimal(string s)
        {
            if (s[s.Length - 1] == '.')
            {
                s += "0";
            }
            return s;
        }
    }
}
