using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Melodi Azizzadeh
//22118080403

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(number1.Text, out int number))
            {
                long factorial = CalculateFactorial(number);
                resultLabel.Text = $"Factorial : { factorial}";
            }
            else
            {
                resultLabel.Text = " Invalid";
            }
        }

        private void PrimeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(number1.Text, out int number))
            {
                // Check if the number is prime
                bool isPrime = IsPrime(number);

                // Display if the number is prime or not
                resultLabel.Text = $"Is Prime: {isPrime}";
            }
            else
            {
                resultLabel.Text = "Invalid input. Please enter a valid number.";
            }
        }
        private void CountButton_Click(object sender, EventArgs e)
        {
            // Get the input number from the text box
            if (int.TryParse(number1.Text, out int number))
            {
                // Count up to the number
                string count = CountUpTo(number);

                // Display the count
                resultLabel.Text = $"Count: {count}";
            }
            else
            {
                resultLabel.Text = "Invalid input. Please enter a valid number.";
            }
        }


        private long CalculateFactorial(int number)
        {
            if (number == 0)
                return 1;

            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private string CountUpTo(int number)
        {
            string count = "";
            for (int i = 1; i <= number; i++)
            {
                count += i + "-";
            }
            return count.TrimEnd('-');
        }


    }
    
}
