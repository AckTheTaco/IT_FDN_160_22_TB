using System;

namespace InventoryFinal
{
    // Item number
    // Description
    // Price Per Item
    // Quantity on Hand
    // Our cost on item
    // Value of item (Cost * quantity)



    struct ItemData
    {
        private string _ItemID;
        private string _Description;
        private double _PricePerItem;
        private int _QuantityOnHand;
        private double _OurCostPerItem;
        private double _ValueOfItem;

        public ItemData(string itemID, string description, double pricePerItem, int quantityOnHand, double ourCostPerItem)
        {
            _ItemID = itemID;
            _Description = description;
            _PricePerItem = pricePerItem;
            _QuantityOnHand = quantityOnHand;
            _OurCostPerItem = ourCostPerItem;
            _ValueOfItem = _PricePerItem * _QuantityOnHand;
        }

        public double ValueOfItems()
        {
            _ValueOfItem = this._QuantityOnHand * this._PricePerItem; // (price * quantity on hand) (ie. a property)
            return _ValueOfItem;

        }

        public string ItemID { get => _ItemID; set => ItemID = value; }
        public string Description { get => _Description; set => Description = value; }
        public double PricePerItem { get => _PricePerItem; set => PricePerItem = value; }
        public int QuantityOnHand { get => _QuantityOnHand; set => QuantityOnHand = value; }
        public double OurCostPerItem { get => _OurCostPerItem; set => OurCostPerItem = value; }
    }


    internal class Program
    {

        static void Main()
        {
            bool run = true;
            var itemDataArray = new ItemData[100];
            int numberOfItems = 0;

            while (run)
            {
                DisplayChoices();
                string action = Console.ReadLine().ToUpper();


                switch (action)
                {
                    case "A":   // 1. add item
                        Console.Clear();
                        Console.WriteLine("\n ~~ Creating a new Item ~~\n");


                        Console.Write("Item ID: ");
                        string itemID = Console.ReadLine();

                        bool taken = false;

                        for (int i = 0; i < numberOfItems; i++)
                        {
                            if (itemDataArray[i].ItemID == itemID)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n ~~ ERROR : ItemID '{itemDataArray[numberOfItems].ItemID} already exists ~~\n");
                                ItemHeader();
                                Console.WriteLine($"{i + 1,5}  {itemDataArray[i].ItemID,6}  {itemDataArray[i].Description,-20}  {itemDataArray[i].PricePerItem,7:C}  {itemDataArray[i].QuantityOnHand,4}  {itemDataArray[i].OurCostPerItem,7:C}  {itemDataArray[i].ValueOfItems(),7:C}");

                                taken = true;
                            }
                        }

                        if (!taken)
                        {
                            Console.Write("Item Description: ");
                            string description = Console.ReadLine();

                            Console.Write("Item Sale Price: ");
                            double pricePerItem = double.Parse(Console.ReadLine());

                            Console.Write("Item(s) on hand: ");
                            int quantityOnHand = int.Parse(Console.ReadLine());

                            Console.Write("Our Cost per Item: ");
                            double ourCostPerItem = double.Parse(Console.ReadLine());

                            itemDataArray[numberOfItems] = new ItemData(itemID, description, pricePerItem, quantityOnHand, ourCostPerItem);
                            Console.Clear();
                            Console.WriteLine($"\n ~~ Item '{itemDataArray[numberOfItems].ItemID} | {itemDataArray[numberOfItems].Description}' Created ~~\n");

                            numberOfItems++;
                        }


                        break;

                    case "C":   // 2. Change Item by giving its item number (change all fields but item number

                        if (numberOfItems == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\n ~~ No Items to change ~~ ");

                            break;
                        }

                        Console.Clear();
                        Console.WriteLine($" \n ~~ List of all Items ~~ ");
                        ItemHeader();
                        ListItems(itemDataArray, numberOfItems);

                        Console.Write("\n\n Enter 'ItemID' like to modify: ");
                        string itemNumberToModify = Console.ReadLine();

                        Console.Clear();
                        ItemHeader();
                        ListItem(itemDataArray, itemNumberToModify);


                        if (itemNumberToModify == null)
                        {
                            Console.WriteLine($"'{itemNumberToModify}' not found.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < numberOfItems; i++)
                            {
                                if (itemDataArray[i].ItemID == itemNumberToModify)
                                {
                                    Console.Write("New Item Description: ");
                                    string newDescription = Console.ReadLine();

                                    Console.Write("New Item Sale Price: ");
                                    double newPrice = double.Parse(Console.ReadLine());

                                    Console.Write("New Item(s) on hand: ");
                                    int newQuantity = int.Parse(Console.ReadLine());

                                    Console.Write("New Our Cost per Item: ");
                                    double newCost = double.Parse(Console.ReadLine());

                                    ModifyItem(itemDataArray, itemNumberToModify, newDescription, newPrice, newQuantity, newCost, i);

                                    break;
                                }
                            }
                        }

                        break;

                    case "D":   // 3. Delete Item by item number

                        if (numberOfItems == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\n ~~ No Items to delete ~~ ");
                            break;
                        }

                        // List out the itemDataArray for the user to see which pet to delete.
                        Console.Clear();
                        Console.WriteLine(" ~~ Items to Delete ~~ ");
                        ItemHeader();
                        ListItems(itemDataArray, numberOfItems);

                        // The user chooses which Item to delete.

                        Console.Write("\n\n Enter 'ItemID' would like to delete: ");
                        string itemToDelete = Console.ReadLine();

                        //The item the user chose will disappear and the itemDataArray after it will shift over it.
                        bool exist = true;
                        for (int i = 0; i < numberOfItems; i++)
                        {
                            if (itemDataArray[i].ItemID != itemToDelete || itemToDelete == null)
                            {
                                Console.Clear();
                                Console.WriteLine($"\n ~~ '{itemToDelete}' does not exist to delete ~~ ");      
                                exist = false;
                            }                            
                        }
                        if (exist)
                        {
                            for (int i = 0; i < numberOfItems; i++)
                            {
                                if (itemDataArray[i].ItemID == itemToDelete)
                                {
                                    Console.Clear();
                                    Console.WriteLine($" ~~ Item '{itemDataArray[i]}' Deleted ~~ ");
                                    itemDataArray[i] = itemDataArray[i + 1];
                                    numberOfItems--;
                                }
                            }
                        }
                        
                        break;

                    case "L":   // 4. List All items in Database
                        if (numberOfItems == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\n ~~ No Items to list ~~ ");
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine($" \n ~~ List of all Items ~~ ");
                        ItemHeader();
                        ListItems(itemDataArray, numberOfItems);
                        break;

                    case "Q":   // 5. Quit
                        Console.Write("Program quit");
                        Console.ReadLine();
                        run = false;
                        break;

                    default:
                        break;
                }

            }


        }

        /* 
         * Format Data output to make it readable
         * Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
         * Console.WriteLine("-----  ------  --------------------  -----  ---  -----  -----");
         */
        private static void ItemHeader()
        {

            Console.WriteLine("\nItem#  ItemID  Description           Price    QOH   Cost     Value");
            Console.WriteLine("-----  ------  --------------------  -------  ----  -------  -------");
        }

        private static void ListItems(ItemData[] itemDataArray, int numberOfItems)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                ItemData item = itemDataArray[i];
                Console.WriteLine($"{i + 1,5}  {item.ItemID,6}  {item.Description,-20}  {item.PricePerItem,7:C}  {item.QuantityOnHand,4}  {item.OurCostPerItem,7:C}  {item.ValueOfItems(),7:C}");
            }
        }

        private static void ListItem(ItemData[] itemDataArray, string itemID)
        {
            for (int i = 0; i < itemDataArray.Length; i++)
            {
                ItemData item = itemDataArray[i];
                if (item.ItemID == itemID)
                {
                    Console.WriteLine($"{i + 1,5}  {item.ItemID,6}  {item.Description,-20}  {item.PricePerItem,7:C}  {item.QuantityOnHand,4}  {item.OurCostPerItem,7:C}  {item.ValueOfItems(),7:C}\n\n");
                }
            }
        }

        private static void DisplayChoices()
        {
            Console.Write("\n\n **Inventory Manager** \n\n 1. (A)dd Item \n 2. (C)hange Item \n 3. (D)elete Item \n 4. (L)ist Items \n 5. (Q)uit \n \nEnter Selection: ");
        }

        private static void ModifyItem(ItemData[] itemDataArray, string itemToModify, string newDescription, double newPrice, int newQuantity, double newCost, int arrayPointer)
        {
            var newItem = new ItemData(itemDataArray[arrayPointer].ItemID, newDescription, newPrice, newQuantity, newCost);

            itemDataArray[arrayPointer] = newItem;
            Console.Clear();
            Console.WriteLine($"\n ~~ Item : {newItem.ItemID} has been edited! ~~ \n");
            Console.WriteLine("\nItem#  ItemID  Description           Price    QOH   Cost     Value");
            Console.WriteLine("-----  ------  --------------------  -------  ----  -------  -------");
            Console.WriteLine($"{arrayPointer + 1,5}  {itemDataArray[arrayPointer].ItemID,6}  {itemDataArray[arrayPointer].Description,-20}  {itemDataArray[arrayPointer].PricePerItem,7:C}  {itemDataArray[arrayPointer].QuantityOnHand,4}  {itemDataArray[arrayPointer].OurCostPerItem,7:C}  {itemDataArray[arrayPointer].ValueOfItems(),7:C}");
        }



    }
}
