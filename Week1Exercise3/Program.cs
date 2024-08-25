using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts for user's loan amount
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            //Stores user's input for loan
            int principal = Convert.ToInt32(Console.ReadLine());
            //Prompts for user's interest rate
            Console.WriteLine("What is the interest rate (input 0.05 for 5%?");
            //Stores user's input for interest rate
            double rate = Convert.ToDouble(Console.ReadLine());
            //Prompts for user's length of loan in years
            Console.WriteLine("What is the period of loan in years?");
            //Stores user's input for length of loan
            int time = Convert.ToInt32(Console.ReadLine());
            //Prints out users total interest of loan
            Console.WriteLine("Total interest of the Loan: " + principal * rate * time + " dollars");
            //Read line of input from user
            Console.Read();
        }
    }
}
