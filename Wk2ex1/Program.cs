using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Wk2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double principal, rate, time, Total_Amount;
            Console.WriteLine("Investment Calculator Program"); //title of calcuator

            Console.WriteLine("What is the amount of the loan in dollars?"); //input of the amount of the loan.
            principal = double.Parse(Console.ReadLine()); //string must be converted from a regular string input into an integer. 

            Console.WriteLine("What is the interest rate (input 0.85 for 5%)"); // input for the interest rate person is getting. 
            rate = double.Parse(Console.ReadLine()); //string must be converted from a regular string input into an integer. 

            Console.WriteLine("What is the period of time of the loan in years?"); //the amount of time the person is going to be having the loan.
            time = double.Parse(Console.ReadLine()); //string must be converted from a regular string input into an integer. 

            Total_Amount = principal * Math.Pow(1 + rate / 100, time); // calculation 

            Console.WriteLine("The total interest of loan is: " + Total_Amount); //final answer.

        }
    }
}
