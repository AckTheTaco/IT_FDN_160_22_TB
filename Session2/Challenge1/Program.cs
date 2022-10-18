using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace Challenge1
{
    internal class Program
    {
        /* 
        1. Write a program that determines if the first character typed in is alphabetic.
        2. Write a program that takes seconds and converts them into days, hours, minutes, and seconds. 
            (Hint: Have a variable that has the number of seconds per day, the number of seconds per hour, and the number of seconds per minute.)
        3. Write a program that, given the number of hours an employee worked and the hourly wage, computes the employee's weekly pay. 
            Count any hours over 40 as overtime at time and a half. 
        4. Write a program that, given an amount prints the appropriate text.For example:
            4580.34 would print "4 Thousand 5 hundred 80 Dollars and 34 cents"*/
        static void Main()
        {
            Challenge1();
        }

        private static void Challenge1() // needs error catching
        {
            string input;
            Console.Write("Input: ");
            input = Console.ReadLine();

            bool isAlphabet = char.IsLetter(input[0]);

            Console.WriteLine(isAlphabet);
            Console.ReadKey();


        }
    }--
}
