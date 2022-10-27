using System;
using System.Linq;
using System.Xml.Linq;

enum EMonthNames
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12,
}
enum eMonthDays
{
    January = 30,
    February = 29,
    March = 31,
    April = 31,
    May = 30,
    June = 31,
    July = 31,
    August = 31,
    September = 31,
    October = 31,
    November = 31,
    December = 31,
}

enum MonthNames
{
    January = 1,
    February = 2,
    March = 3,
    April = 4
}

enum DaysPerMonth
{
    January = 30,
    February = 30,
    March = 30,
    April = 30,
    May = 30,
}

class Ascii
{


    static void Main()
    {
        // LabOne();
        // LabTwo();
        // LabThree();
        // LabTut();
        // LabFour();

        ChallengeFour();
    }

    private static void LabTut()
    {
        DaysPerMonth days;

        days = DaysPerMonth.May;

        Console.WriteLine("The Month is {0} and its integer value is {1}",
            days, (int)days);

        Console.ReadLine();
    }

    private static void LabOne() // Data Conversion and ASCII Lookup
    {
        Console.Write("Enter a character:");

        // Let the user enter a string and press enter.
        // code here = Console.ReadLine();
        Console.WriteLine("Enter a character: ");
        string input = Console.ReadLine();

        // Grab the first character of the string (str[0])
        // code here = str[0];
        char firstChar = input[0];

        // Convert the character to an integer to get the ascii value
        // code here = (int)ch;
        int ascii = (int)firstChar;

        Console.WriteLine("ascii value of {0} is : {1}", input, ascii);  // show the ascii value
        Console.ReadLine();
    }

    static void LabTwo() // Switch Statements
    {
        Console.Write("Please enter a month number (1 to 12): ");
        string monthNumber = Console.ReadLine();

        string month = null; // Must assign to Null
        int daysOfTheMonth = 0;

        switch (monthNumber)
        {
            case "1":
                month = "Jan";
                daysOfTheMonth = 31;
                break;

            case "2":
                month = "Feb";
                daysOfTheMonth = 28;
                break;

            case "3":
                month = "Mar";
                daysOfTheMonth = 31;
                break;
            case "4":
                month = "April";
                daysOfTheMonth = 30;
                break;
            case "5":
                month = "May";
                daysOfTheMonth = 31;
                break;
            case "6":
                month = "June";
                daysOfTheMonth = 30;
                break;
            case "7":
                month = "July";
                daysOfTheMonth = 31;
                break;
            case "8":
                month = "Aug";
                daysOfTheMonth = 31;
                break;
            case "9":
                month = "Sept";
                daysOfTheMonth = 30;
                break;
            case "10":
                month = "Oct";
                daysOfTheMonth = 31;
                break;
            case "11":
                month = "Nov";
                daysOfTheMonth = 30;
                break;
            case "12":
                month = "Dec";
                daysOfTheMonth = 31;
                break;
            default:
                Console.WriteLine("Number entered not in calander year");
                LabTwo();
                break;
        }

        Console.WriteLine("The month {0} has {1} days", month, daysOfTheMonth);
        Console.ReadLine();
    }

    static void LabThree() // String Manipulation
    {
        Console.Write("Enter a person's full name:");
        string str = Console.ReadLine();
        

        if (str.ToLower().Contains(" smith"))
        {
            Console.WriteLine("Smith was found");
        }
        else
        {
            Console.WriteLine("Smith was not found");
        }

        Console.ReadLine();
    }

    // Create a program that determines the number of days for a month using a switch statement. 
    // The program should accept the number of the month in question.

    static void LabFour() // Enums and Switch Statments in action
    {
        Console.Write("Please enter a Month Number: ");
        string monthNumber = Console.ReadLine();

        int nDays = 0;

        EMonthNames eName;

        switch (monthNumber)
        {
            case "1":
                eName = EMonthNames.January;
                nDays = (int)eMonthDays.January;

                break;
            case "2":
                eName = EMonthNames.February;
                nDays = (int)eMonthDays.February;

                break;
            case "3":
                eName = EMonthNames.March;
                nDays = (int)eMonthDays.March;

                break;
            case "4":
                eName = EMonthNames.April;
                nDays = (int)eMonthDays.April;

                break;
            case "5":
                eName = EMonthNames.May;
                nDays = (int)eMonthDays.May;

                break;
            case "6":
                eName = EMonthNames.June;
                nDays = (int)eMonthDays.June;

                break;
            case "7":
                eName = EMonthNames.July;
                nDays = (int)eMonthDays.July;

                break;
            case "8":
                eName = EMonthNames.August;
                nDays = (int)eMonthDays.August;

                break;
            case "9":
                eName = EMonthNames.September;
                nDays = (int)eMonthDays.September;

                break;
            case "10":
                eName = EMonthNames.October;
                nDays = (int)eMonthDays.October;

                break;
            case "11":
                eName = EMonthNames.November;
                nDays = (int)eMonthDays.November;

                break;
            case "12":
                eName = EMonthNames.December;
                nDays = (int)eMonthDays.December;

                break;
            default:
                Console.WriteLine("Error");
                eName = 0;
                LabFour();

                break;
        }

        Console.WriteLine("Month {0} has {1} days\n\n", eName, nDays);
        Console.ReadLine();
    }
    static void ChallengeFour()
    {
        /*
        1.Write a program that calculates the sum of the digits of an integer. 
        Do not use the input string, convert the user inputted string to an integer and process that integer. 
        For example, the sum of the digits of the integer number 2155 is 2 + 1 + 5 + 5 or 13.
        The program should accept any arbitrary integer typed in by the user and output the following: 
        
        2155 = 2 + 1 + 5 + 5 = 13

        (Hint: Assume the number is never greater than 9999.)

        -----> 2.Write a program to reverse a given string(apple will be reversed to elppa) or to reverse a given number(1234 will become 4321).

        3.Write a program to convert all a given uppercase string into a lowercase string.

        4.Write a program that calculates the average of 10 floating point values given by the user.
        */

        Console.WriteLine("Enter a number under 9999");
        string input = Console.ReadLine();

        var total = 0;
        for (int i = 0; i < input.Length; i++)
        {

            var digit = (int)Char.GetNumericValue(input[i]);

            total += digit;

            // Console.WriteLine(digit); Shows what it is reading.
        }

        Console.WriteLine(total);

        string reverse;

        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[(input.Length-i)]);
        }



       

        Console.ReadLine();
    }


}



