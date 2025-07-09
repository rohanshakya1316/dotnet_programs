using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetLabs
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFactorial_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtInput.Text, out n) && n >= 0)
            {
                long fact = 1;
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }
                txtOutput.Text = $"Factorial of {n} is {fact}";
            }
            else
            {
                txtOutput.Text = "Please enter a valid non-negative integer.";
            }
        }

        protected void btnPrime_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtInput.Text, out n) && n >= 2)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                txtOutput.Text = isPrime ? $"{n} is a prime number." : $"{n} is not a prime number.";
            }
            else
            {
                txtOutput.Text = "Enter an integer ≥ 2 to check for prime.";
            }
        }

        protected void btnFactorialSeries_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtInput.Text, out n) && n >= 1)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= n; i++)
                {
                    long fact = 1;
                    for (int j = 2; j <= i; j++)
                    {
                        fact *= j;
                    }
                    sb.AppendLine($"Factorial of {i} is {fact}");
                }
                txtOutput.Text = sb.ToString();
            }
            else
            {
                txtOutput.Text = "Enter a number ≥ 1 for factorial series.";
            }
        }
    }
}