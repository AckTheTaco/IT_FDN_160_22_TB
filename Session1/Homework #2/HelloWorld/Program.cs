using System;

class Program
{
    static void Main() //Starting point for compiler
    {
        /* Console.WriteLine("Hello World, TonyB!" );
         Console.ReadLine();*/
        // Vars();
        // Formatting();
        // Conversions();
        // Poly();
        Homework3();
    }




    static void Vars() // Lab complete
    {
        // Declare a variable named "age" of type "int"
        int age;

        // Set the value of "age" to 21
        age = 21;

        Console.WriteLine("My age is {0}", age);

        // increment age by 2
        age += 2;

        Console.WriteLine("My real age is {0}", age);
        Console.ReadLine();
    }

    static void Formatting() // Lab complete
    {
        Console.WriteLine("ID    Name       Price");
        Console.WriteLine("----- ---------- --------");
        Console.WriteLine("{0, 5} {1, -10} {2, 8:C}", 101, "apple", .25);
        Console.WriteLine("{0, 5} {1, -10} {2, 8:C}", 102, "pear", .26);
        Console.WriteLine("{0, 5} {1, -10} {2, 8:C}", 4, "pineapple", 1.20);
        Console.ReadLine();
    }

    static void Conversions() // Lab Compelete
    {
        // Display "Enter a price:" using Console.Write
        Console.Write("Enter a price: ");

        // Define a string named "input"
        string input;

        // Assign "input" to Console.ReadLine() to allow the user to enter a price
        input = Console.ReadLine();

        // Define a double named price
        double price;

        // Convert the "input" into a double using Parse()
        price = double.Parse(input);

        // Display the price as currency ( {0:C} )
        Console.WriteLine("The price is : {0:C}", price);
        Console.ReadLine();
    }

    static void Poly() // Complete without use of carrot key
    {
        // Ask for an input 
        Console.Write("Please enter an integer value for x: ");

        // Read the input and save it into a String Type
        string input;
        input = Console.ReadLine();

        // Convert the String Type into an Integer Type
        int x;  // convert a string into an integer type
        x = int.Parse(input);

        // Calculate the Polynomial (3x^3-5x^2+6) and save it into an Integer Type
        int result;
        result = (3 * (x * x * x) - 5 * (x * x) + 6);

        // Show the result on the Console (on the screen)
        Console.WriteLine("The calculated value for 3x^3-5x^2+6 is {0}", result);

        // Hold the Console so we can see the result
        Console.ReadLine();
    }

    static void Homework3()
    {
        // Write a program that takes seconds and converts to days, hours, minutes, and seconds
        int secPerDay = 86400;
        int secPerHour = 3600;
        int secPerMinute = 60;

        int input, days, hours, minutes, seconds;

        Console.Write("Input amount of seconds to convert: ");

        input = int.Parse(Console.ReadLine());

        days = input / secPerDay;
        hours = (input % secPerDay) / secPerHour;
        minutes = (input % secPerHour) / secPerMinute;
        seconds = (input % secPerMinute);

        if (days > 0)
        {
            Console.WriteLine("{0} day(s), {1} hour(s), {2} minute(s), {3} second(s)", days, hours, minutes, seconds);
        }
        else if (hours > 0)
        {
            Console.WriteLine("{1} hour(s), {2} minute(s), {3} second(s)", days, hours, minutes, seconds);
        }
        else if (minutes > 0)
        {
            Console.WriteLine("{2} minute(s), {3} second(s)", days, hours, minutes, seconds);
        }
        else
        {
            Console.WriteLine("{3} second(s)", days, hours, minutes, seconds);
        }
        Console.ReadLine();

    }
}