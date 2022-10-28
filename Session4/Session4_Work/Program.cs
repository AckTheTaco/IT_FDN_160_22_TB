using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Work
{
    internal class Program
    {
        static void Main()
        {
            int result = 1;
            int input = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a samll number: ");

            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine("{0}! is {1}", input, result);
            Console.ReadLine(); 
        }
    }
}
