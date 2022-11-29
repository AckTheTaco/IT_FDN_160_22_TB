using System;
using System.Collections.Generic;
using System.

struct Contact
{
    public int ContactId;
    public String Name;
    public String PhoneNumber;

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        ContactId = CurrentNextContactId;
    }

    public static int CurrentNextContactId
    { get  { return nextContactId++; } }


    private static int nextContactId = 100;
    // TODO: Create static nextContactId

}

class Sorter
{
    public static void BubbleSort(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            for (int inner = index; inner < array.Length; inner++)
            {
                if (array[index] > array[inner])
                {
                    Swap(ref array[index], ref array[inner]);
                }
            }
        }
    }

    private static void Swap(ref int first, ref int second)
    {
        var temp = first;
        first = second;
        second = temp;
    }

    // TODO: Add static Print function

    public static void Print(string title, int[] ints)
    {

        Console.WriteLine(title);

        foreach (int i in ints)
        {
            Console.Write($"{i}, ");
        }

        Console.WriteLine("\n");

    }
}

class Program
{
    static void Main()
    {
        //Lab1();

        //Lab2();

        // Lab3();

        Lab4();
    }

    private static void Lab4()
    {
        // TODO: Create a list of Contact
        var contacts = new List<Contact>();

        // TODO: Add contacts to the list
        contacts.Add(new Contact("mike", "111-222-3333"));
        contacts.Add(new Contact("tom", "555-222-3333"));

        // TODO: Display the Name and PhoneNumber of all the contacts
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Name} : {contact.PhoneNumber}");
        }

        Console.ReadLine();
    }

    private static void Lab3()
    {
        var values = new int[] { 5, 4, 3, 2, 1 };

        Sorter.Print("Not sorted: ", values);
        Sorter.BubbleSort(values);
        Sorter.Print("Sorted: ", values);

        Console.ReadLine();
    }

    private static void Lab2()
    {
        Console.WriteLine("CurrentNextContactId = {0} should be 100", Contact.CurrentNextContactId);

        var contact = new Contact("mike", "111-222-3333");

        // TODO: Why does is not compile? What does the compiler say?
        Console.WriteLine("CurrentNextContactId = {0} should be 101", contact.ContactId);

        var contact2 = new Contact("steve", "222-333-4444");

        // TODO: Why does is not compile? What does the compiler say?
        Console.WriteLine("CurrentNextContactId = {0} should be 102", contact2.ContactId);

        Console.ReadLine();
    }

    private static void Lab1()
    {
        var contact = new Contact("mike", "111-222-3333");

        Console.WriteLine("ContactId = {0} should be 100", contact.ContactId);

        var contact2 = new Contact("steve", "222-333-4444");

        Console.WriteLine("ContactId = {0} should be 101", contact2.ContactId);

        var contact3 = new Contact("frank", "555-333-4444");

        Console.WriteLine("ContactId = {0} should be 102", contact3.ContactId);

        Console.ReadLine();
    }
}