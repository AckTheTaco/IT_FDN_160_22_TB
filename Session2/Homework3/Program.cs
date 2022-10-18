using System;

namespace Homework3
{
    internal class Program
    {
        static void Main()
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

            Console.WriteLine("{0} day(s), {1} hour(s), {2} minute(s), {3} second(s)", days, hours, minutes, seconds);
            Console.ReadLine();
        }
    }
}
