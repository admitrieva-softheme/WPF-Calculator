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
        static string defaultString = "0.0";
        string numberOneBuffer;
        string numberTwoBuffer;
        Calc c;
        public MainWindow()
        {
            InitializeComponent();
            c = new Calc();
            textBox1.Text = defaultString;

            numberOneBuffer = "";
            numberTwoBuffer = "";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "1";
            textBox1.Text = numberOneBuffer;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "2";
            textBox1.Text = numberOneBuffer;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "3";
            textBox1.Text = numberOneBuffer;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "4";
            textBox1.Text = numberOneBuffer;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "5";
            textBox1.Text = numberOneBuffer;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "6";
            textBox1.Text = numberOneBuffer;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "7";
            textBox1.Text = numberOneBuffer;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "8";
            textBox1.Text = numberOneBuffer;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "9";
            textBox1.Text = numberOneBuffer;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "0";
            textBox1.Text = numberOneBuffer;
        }

        private void decipoint_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += ".";
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string answer = "";
            if (c.isFirstOperation() || ((numberOneBuffer.Length > 0) && (numberTwoBuffer.Length > 0)))
            {
                answer = c.operate(Convert.ToDouble(numberTwoBuffer), Convert.ToDouble(numberOneBuffer));
            }
            else
            {
                answer = c.operate(Convert.ToDouble(numberTwoBuffer));
            }

            textBox1.Text = answer;

            numberOneBuffer = "";
            numberTwoBuffer = "";
        }

        private void sign_Click(object sender, RoutedEventArgs e)
        {
            if (numberOneBuffer.Length > 0)
            {
                if (numberOneBuffer[0] == '-')
                {
                    numberOneBuffer = numberOneBuffer.Substring(1, numberOneBuffer.Length - 1);
                }
                else
                {
                    numberOneBuffer = "-" + numberOneBuffer;
                }
            }
            else
            {
                numberOneBuffer = "-" + numberOneBuffer;
            }
            textBox1.Text = Convert.ToString(numberOneBuffer);
        }

        private void clearentry_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer = "";
            textBox1.Text = defaultString;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            numberOneBuffer = "";
            c.reset();
            textBox1.Text = defaultString;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if ((numberOneBuffer.Length > 0) && (numberTwoBuffer.Length > 0))
            {
                string answer = c.operate(Convert.ToDouble(numberTwoBuffer), Convert.ToDouble(numberOneBuffer));
                textBox1.Text = answer;
                c.setOperation(Calc.Operators.Addition);
            }
            else
            {
                c.setOperation(Calc.Operators.Addition);
                numberTwoBuffer = numberOneBuffer;
                numberOneBuffer = string.Empty;
            }

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if ((numberOneBuffer.Length > 0) && (numberTwoBuffer.Length > 0))
            {
                textBox1.Text = c.operate(Convert.ToDouble(numberTwoBuffer), Convert.ToDouble(numberOneBuffer));
            }
            c.setOperation(Calc.Operators.Subtraction);
            numberTwoBuffer = numberOneBuffer;
            numberOneBuffer = string.Empty;
        }

        private void multiple_Click(object sender, RoutedEventArgs e)
        {
            if ((numberOneBuffer.Length > 0) && (numberTwoBuffer.Length > 0))
            {
                textBox1.Text = c.operate(Convert.ToDouble(numberTwoBuffer), Convert.ToDouble(numberOneBuffer));
            }
            c.setOperation(Calc.Operators.Multiplication);
            numberTwoBuffer = numberOneBuffer;
            numberOneBuffer = string.Empty;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if ((numberOneBuffer.Length > 0) && (numberTwoBuffer.Length > 0))
            {
                textBox1.Text = c.operate(Convert.ToDouble(numberTwoBuffer), Convert.ToDouble(numberOneBuffer));
            }
            c.setOperation(Calc.Operators.Division);
            numberTwoBuffer = numberOneBuffer;
            numberOneBuffer = string.Empty;
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
