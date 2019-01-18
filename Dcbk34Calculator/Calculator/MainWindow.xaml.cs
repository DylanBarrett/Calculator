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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        const string startString = "     ";
        const string squareErrorMessage = "You tried to square root a negative number. You cannot do this.";
        const string divideErrorMessage = "You tried to divide a number by zero, this isn't allowed in math.";
        const string inputErrorMessage = "You tried to input an invalid operation, please try again.";
        string checkString;
        double Argument1 = 0;
        double Argument2 = 0;
        double equalResult = 0;
        double equalArgument = 0;
        bool isAdd = false;
        bool isSub = false;
        bool isDiv = false;
        bool isMulti = false;
        bool isEqual = false;
        bool isSquared = false;
        bool isSquareRoot = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void OneClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "1";
            InputField.IsReadOnly = true;
            return;
        }
        private void TwoClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "2";
            InputField.IsReadOnly = true;
            return;
        }
        private void ThreeClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "3";
            InputField.IsReadOnly = true;
            return;
        }
        private void FourClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "4";
            InputField.IsReadOnly = true;
            return;
        }
        private void FiveClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "5";
            InputField.IsReadOnly = true;
            return;
        }
        private void SixClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "6";
            InputField.IsReadOnly = true;
            return;
        }
        private void SevenClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "7";
            InputField.IsReadOnly = true;
            return;
        }
        private void EightClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "8";
            InputField.IsReadOnly = true;
            return;
        }
        private void NineClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "9";
            InputField.IsReadOnly = true;
            return;
        }
        private void ZeroClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text += "0";
            InputField.IsReadOnly = true;
            return;
        }
        private void PeriodClicked(object sender, RoutedEventArgs e)
        {
            checkString = InputField.Text.Trim();
            if(checkString.Contains("."))
            {
                return;
            }
            InputField.IsReadOnly = false;
            InputField.Text += ".";
            InputField.IsReadOnly = true;
            return;
        }
        private void ClearClicked(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            InputField.Text = startString;
            InputField.IsReadOnly = true;
            return;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(InputField.Text, out Argument1))
            {
                MessageBox.Show(this, inputErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquareRoot = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }
            InputField.IsReadOnly = false;
            InputField.Text = startString;
            InputField.IsReadOnly = true;
            isAdd = true;
            isSub = false;
            isDiv = false;
            isMulti = false;
            isSquareRoot = false;
            isEqual = false;
            return;
        }
        private void Equation(object sender, RoutedEventArgs e)
        {
            if (!isEqual)
            {
                if (!double.TryParse(InputField.Text, out Argument2))
                {
                    MessageBox.Show(this, inputErrorMessage);
                    Argument1 = 0;
                    Argument2 = 0;
                    equalResult = 0;
                    equalArgument = 0;
                    isAdd = false;
                    isSub = false;
                    isDiv = false;
                    isMulti = false;
                    isSquareRoot = false;
                    isEqual = false;
                    InputField.IsReadOnly = false;
                    InputField.Text = startString;
                    InputField.IsReadOnly = true;
                    return;
                }

                if (isAdd)
                {
                    equalResult = Argument1 + Argument2;
                }
                else if (isSub)
                {
                    equalResult = Argument1 - Argument2;
                }
                else if (isMulti)
                {
                    equalResult = Argument1 * Argument2;
                }
                else if (isDiv)
                {
                    if (Argument2 == 0)
                    {
                        MessageBox.Show(this, divideErrorMessage);
                        Argument1 = 0;
                        Argument2 = 0;
                        equalResult = 0;
                        equalArgument = 0;
                        isAdd = false;
                        isSub = false;
                        isDiv = false;
                        isMulti = false;
                        isSquareRoot = false;
                        isEqual = false;
                        InputField.IsReadOnly = false;
                        InputField.Text = startString;
                        InputField.IsReadOnly = true;
                        return;
                    }
                    equalResult = Argument1 / Argument2;
                }

                InputField.IsReadOnly = false;
                equalArgument = Argument2;
                InputField.Text = startString + System.Convert.ToString(equalResult);
                InputField.IsReadOnly = true;
                isEqual = true;
                return;
            }
            else
            {

                double.TryParse(InputField.Text, out Argument2);
                if (isAdd)
                {
                    equalResult = Argument2 + equalArgument;
                }
                else if (isSub)
                {
                    equalResult = Argument2 - equalArgument;
                }
                else if (isMulti)
                {
                    equalResult = Argument2 * equalArgument;
                }
                else if (isDiv)
                {
                    equalResult = Argument2 / equalArgument;
                }
                else if (isSquareRoot)
                {
                    equalResult = Math.Sqrt(Argument2);
                }
                InputField.IsReadOnly = false;
                InputField.Text = startString + equalResult;
                InputField.IsReadOnly = true;
                return;
            }
        }

        private void Div(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(InputField.Text, out Argument1))
            {
                MessageBox.Show(this, inputErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquareRoot = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }
            InputField.IsReadOnly = false;
            InputField.Text = startString;
            InputField.IsReadOnly = true;
            isAdd = false;
            isSub = false;
            isDiv = true;
            isMulti = false;
            isSquareRoot = false;
            isEqual = false;
            return;
        }

        private void Multi(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(InputField.Text, out Argument1))
            {
                MessageBox.Show(this, inputErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquareRoot = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }
            InputField.IsReadOnly = false;
            InputField.Text = startString;
            InputField.IsReadOnly = true;
            isAdd = false;
            isSub = false;
            isDiv = false;
            isMulti = true;
            isSquareRoot = false;
            isEqual = false;
            return;
        }

        private void Sub(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(InputField.Text, out Argument1))
            {
                MessageBox.Show(this, inputErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquareRoot = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }
            InputField.IsReadOnly = false;
            InputField.Text = startString;
            InputField.IsReadOnly = true;
            isAdd = false;
            isSub = true;
            isDiv = false;
            isMulti = false;
            isSquareRoot = false;
            isEqual = false;
            return;
        }

        private void SquareRoot(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(InputField.Text, out Argument1))
            {
                MessageBox.Show(this, inputErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquareRoot = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }
            if (Argument1 < 0)
            {
                MessageBox.Show(this, squareErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquareRoot = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }

            InputField.IsReadOnly = false;
            InputField.Text = startString + Math.Sqrt(Argument1);
            InputField.IsReadOnly = true;


            isAdd = false;
            isSub = false;
            isDiv = false;
            isMulti = false;
            isSquareRoot = true;
            isEqual = true;

            return;

        }
        private void Squared(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(InputField.Text, out Argument1))
            {
                MessageBox.Show(this, inputErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquared = false;
                isSquareRoot = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }
            if (Argument1 < 0)
            {
                MessageBox.Show(this, squareErrorMessage);
                Argument1 = 0;
                Argument2 = 0;
                equalResult = 0;
                equalArgument = 0;
                isAdd = false;
                isSub = false;
                isDiv = false;
                isMulti = false;
                isSquareRoot = false;
                isSquared = false;
                isEqual = false;
                InputField.IsReadOnly = false;
                InputField.Text = startString;
                InputField.IsReadOnly = true;
                return;
            }

            InputField.IsReadOnly = false;
            InputField.Text = startString + Math.Pow(Argument1, 2);
            InputField.IsReadOnly = true;


            isAdd = false;
            isSub = false;
            isDiv = false;
            isMulti = false;
            isSquareRoot = false;
            isSquared = true;
            isEqual = true;

            return;

        }

        private void NegativeClick(object sender, RoutedEventArgs e)
        {
            InputField.IsReadOnly = false;
            checkString = InputField.Text.Trim();
            if (checkString.Contains("-"))
            {
                checkString = checkString.Replace("-", "");
                InputField.Text = startString + checkString;
                InputField.IsReadOnly = true;
                return;
            }
            checkString = checkString.Insert(0, "-");
            InputField.Text = startString + checkString;
            InputField.IsReadOnly = true;
            return;
        }

        private void CloseCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();

        }
        private void MaximizedScreenHandler(object sender, ExecutedRoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                return;
            }
            this.WindowState = WindowState.Normal;
            return;
        }

    }
}