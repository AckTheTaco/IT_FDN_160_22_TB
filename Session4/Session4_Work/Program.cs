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
            // Homework4();
            // Lab1();
            // Lab2();
            // Lab3();
            // Lab4();

        }

        static void Homework4()
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

        /*
         * Lecture on Loops Session 4
         * While - For - Arrays - Foreach
         * 
        */

        /*
        * Modify the following program to allow the user to enter a number 
        * and then keep track of the running sum that is less than 100.
        */

        // WHile Loop
        static void Lab1()
        {
            int sum = 0;

            while (sum < 100)
            {
                Console.Write("Enter a number:");
                string input = Console.ReadLine();

                int number = int.Parse(input);

                sum += number;

                Console.WriteLine("Current sum is {0}", sum);
            }

            Console.ReadLine();
        }


        // Write a program that calculates the average of numbers given by the user.
        // For Loop
        static void Lab2()
        {
            // define a float for sum
            // define a float for average
            float sum = 0;
            float average = 0;

            // sequentially add the numbers up from 0 to 10

            for (int i = 0; i < 10; i++)
            {
                //ask the user to enter a number
                Console.WriteLine("({0}) Enter a number: ", i + 1);

                //add the given number to the previous
                sum += float.Parse(Console.ReadLine());
            }

            // finding the average
            average = sum / 10;
            Console.WriteLine("The average of the given numbers is {0}", average);
            Console.ReadLine();
        }


        //Arrays and for loop to search
        static void Lab3()
        {
            while (true)
            {
                int[] numbers = new int[] { 10, 15, 20, 25, 30, 35 };

                Console.Write("Enter a number:");
                string str = Console.ReadLine();

                // TODO: convert input string into a number
                int input = int.Parse(str);

                // TODO: set a boolean flag named "found"
                bool found = false;

                // use for to look for the number
                for (int i = 0; i < numbers.Length; i++)
                {
                    // TODO: if number is found set found flag to true and exit the loop
                    if (numbers[i] == input)
                    {
                        found = true;
                    }
                }

                if (found) // if true, i.e. found the number, say Found the Number
                {
                    Console.WriteLine("Found the number!");
                }
                else // if not true, did not find it, say Did not Find the Number
                {
                    Console.WriteLine("Sorry, did not find the number");
                }

                Console.ReadLine(); // Pause to see the results
            }
        }

        // Create an array of numbers and find the max and min values of your array
        static void Lab4()
        {
            // start with the given array
            int[] numbers = new int[] { 0, 2, 5, 100, -1, 4, 8, -5 };

            var no = 1;
            no.GetType();

            // define the max and min
            int max = 0; 
            int min = 0;

            foreach (int x in numbers)
            {
                if (x == numbers.Min())
                {
                    // code to find the min
                    min = x;
                }
                if (x == numbers.Max())
                {
                    // code to find the max
                    max = x;
                }
            }

            Console.WriteLine("The Minimum value is {0}", min);
            Console.WriteLine("The Maximum value is {0}", max);
            Console.ReadLine();
        }
    }
}
