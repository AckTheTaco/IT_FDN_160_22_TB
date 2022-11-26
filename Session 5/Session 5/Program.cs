using System;
using System.Reflection;

public struct Pet
{
    public string Name;
    public string TypeOfPet;
}

class Program
{
    

    static void Main()
    {
        int numberOfPets = 0;
        var pets = new Pet[10];

        while (true)
        {
            Console.Write("\n A)dd C)hange D)elete L)ist pets:");
            var choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "a": // Add
                    {
                        string name, typeOfPet;

                        NamePet(out name, out typeOfPet);

                        if (numberOfPets == 0)
                        {
                            MakeNewPet(name, typeOfPet, pets, 0);
                            numberOfPets++; // I want this in the method itself
                            break;
                        }

                        MakeNewPet(name, typeOfPet, pets, numberOfPets );  //// How would I update "numberOfPets" from within the method ?
                        numberOfPets++; // I want this in the methof itself

                    
                        break;
                    }

                case "c": // Change
                    {
                        // TODO
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("No pets");
                            break;
                        }

                        ListPets(numberOfPets, pets);

                        Console.Write("\n Which pet to edit (1-{0}): ", numberOfPets);

                        var petNumberToEdit = Console.ReadLine();
                        var indexToEdit = int.Parse(petNumberToEdit);

                        string name, type;

                        NamePet(out name, out type);

                        InsertPet(pets, indexToEdit, name, type);

                        break;
                    }

                case "d": // Delete
                    {
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("\n No pets");
                            break;
                        }

                        ListPets(numberOfPets, pets);

                        Console.Write($"\n Which pet to remove (1-{numberOfPets})");
                        var petToDelete = Console.ReadLine();

                        DeletePet(numberOfPets, pets, petToDelete);

                        numberOfPets--; // I want this inside of the "DeletePet" Method.... How do?

                        break;
                    }

                case "l": // List
                    {
                        if (numberOfPets == 0)
                        {
                            Console.WriteLine("\n No pets");
                            break;
                        }

                        ListPets(numberOfPets, pets);

                        break;
                    }
                default:
                    {
                        Console.WriteLine("\n Invalid option [{0}]", choice);
                        break;
                    }
            }
        }
    }

    private static void DeletePet(int numberOfPets, Pet[] pets, string petNumberToDelete)
    {
        var indexToDelete = int.Parse(petNumberToDelete);

        // Squish the array from index to the end

        for (var index = indexToDelete - 1; index < numberOfPets; index++)
        {
            // TODO: Just copy the pet from the next index into the current index
            pets[index] = pets[index + 1];
        }
    }

    private static void NamePet(out string name, out string typeOfPet)
    {
        //Ask for pet Name
        Console.Write("\nName: ");
        name = Console.ReadLine();

        // Ask for pet Type
        Console.Write("Type of pet: ");
        typeOfPet = Console.ReadLine();
    }

    private static void InsertPet(Pet[] arrayOfPets, int indexToEdit, string newName, string newType)
    {
        var newPet = new Pet();

        newPet.Name = newName;
        newPet.TypeOfPet = newType;

        arrayOfPets[indexToEdit - 1] = newPet;

        Console.WriteLine($"\n Pet : {indexToEdit}. {newPet.Name} has been edited! \n");
    }

    private static void ListPets(int numberOfPets, Pet[] pets)
    {
        Console.WriteLine("\n");

        for (var index = 0; index < numberOfPets; index++)
        {
            Console.WriteLine("{0}.  {1,-10} : {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
        }
    }

    private static void MakeNewPet(string name, string type, Pet[] pets, int locationIndex)
    {
        pets[locationIndex].Name = name;
        pets[locationIndex].TypeOfPet = type;
    }
}