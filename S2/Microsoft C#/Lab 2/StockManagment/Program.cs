using System;

namespace StockManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();
            list.Add(new Item(list.Count(), "Weird thumb", 3.0, 10));
            bool exit = false;
            do
            {
                Console.WriteLine("1.Search for an article by reference.");
                Console.WriteLine("2.Add an item to the stock by checking the uniqueness of the reference.");
                Console.WriteLine("3.Delete an article by reference.");
                Console.WriteLine("4.Modify an article by reference.");
                Console.WriteLine("5.Search for an article by name.");
                Console.WriteLine("6.Search for an item by sale price range.");
                Console.WriteLine("7.View all articles.");
                Console.WriteLine("8.Quit.\n");
                Console.WriteLine("Type a number to select an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Item it = findItem(list);
                        Console.WriteLine(it.ToString());

                        break;

                    case 2:
                        Console.WriteLine("\nName of item: ");
                        string itemName = Console.ReadLine();
                        Console.WriteLine("\nPrice: ");
                        double itemPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nQuantity: ");
                        int itemQuantity = int.Parse(Console.ReadLine());

                        Item newItem = new Item(list.Count(), itemName, itemPrice, itemQuantity);

                        if (list.Contains(newItem)) Console.WriteLine("Item is already in the list");
                        list.Add(newItem);

                        break;

                    case 3:
                        list = deleteItem(list);
                        break;

                    case 4:
                        Console.WriteLine("\nWhich item do you want to modify ? ( type number of item)\n");
                        //Item it = findItem(list);
                        list = modifyItem(list);
                        break;

                    case 5:
                        //Console.WriteLine("\nWhich item do you want to modify ? ( type number of item)\n");
                        Item itName = findItemByName(list);
                        if (itName != null) Console.WriteLine(itName.ToString());
                        break;

                    case 6:
                        list = findItemByPriceRange(list);
                        break;

                    case 7:
                        allItems(list);
                        break;

                    case 8:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nThis option doesn't exist, please select an option from the menu\n");
                        break;
                }
            } while (!exit);

        }

        public static Item findItem(List<Item> items)
        {
            bool booleanValue = false;
            Item itemFound = null;
            do
            {
                Console.WriteLine("Type in the number of the item you're looking for : ");
                int nb = int.Parse(Console.ReadLine());
                foreach (Item item in items)
                {
                    if (nb == item.getNumber())
                    {
                        booleanValue = true;
                        itemFound = item;
                        break;
                    }

                }
            } while (!booleanValue);
            return itemFound;
        }

        public static List<Item> modifyItem(List<Item> items)
        {
            Console.WriteLine("Type in the number of the item you're looking for : ");
            int nb = int.Parse(Console.ReadLine());
            foreach (Item item in items)
            {
                if (nb == item.getNumber())
                {
                    bool valid = false;
                    do
                    {
                        Console.WriteLine("\n1.Name\n2.Price\n3.Quantity\n");
                        Console.WriteLine("What do you want to modify ? ");
                        int modification = int.Parse(Console.ReadLine());
                        switch (modification)
                        {
                            case 1:
                                item.setName(Console.ReadLine());
                                valid = true;
                                break;
                            case 2:
                                item.setPrice(double.Parse(Console.ReadLine()));
                                valid = true;
                                break;
                            case 3:
                                item.setQuantity(int.Parse(Console.ReadLine()));
                                valid = true;
                                break;
                            default:
                                Console.Write("\nPlease choose something to modify...\n");
                                break;
                        }
                    } while (!valid);

                    return items;
                }

            }
            Console.WriteLine("\nItem not found\n");
            return items;
        }

        public static List<Item> deleteItem(List<Item> items)
        {
            List<Item> list = new List<Item>();
            bool isHere = false;
            int nb = int.Parse(Console.ReadLine());
            foreach (Item item in items)
            {
                if (nb != item.getNumber())
                {
                    list.Add(item);
                }
                else
                {
                    isHere = true;
                }

            }
            if (!isHere) Console.WriteLine("\nItem not found\n");
            return list;
        }

        public static Item findItemByName(List<Item> items)
        {
            bool booleanValue = false;
            Item itemFound = null;
            do
            {
                Console.WriteLine("Type in the name of the item you're looking for : ");
                string name = Console.ReadLine();
                foreach (Item item in items)
                {
                    if (name == item.getName())
                    {
                        booleanValue = true;
                        itemFound = item;
                        break;
                    }

                }
                if (!booleanValue) Console.Write("\n...Please type an item number that exist\n");
            } while (!booleanValue);
            return itemFound;
        }

        public static List<Item> findItemByPriceRange(List<Item> items)
        {
            bool booleanValue = false;
            List<Item> list = new List<Item>();
            do
            {
                int min;
                int max;

                do
                {
                    Console.WriteLine("Type in theprice range of the item you're looking for : ");
                    min = int.Parse(Console.ReadLine());
                    max = int.Parse(Console.ReadLine());

                } while (max < min);

                foreach (Item item in items)
                {
                    if (item.getPrice() >= min && item.getPrice() <= max)
                    {
                        booleanValue = true;
                        list.Add(item);
                        break;
                    }
                }
                if (!booleanValue) Console.Write("\n...Please type an item number that exist\n");
            } while (!booleanValue);

            return list;
        }

        public static void allItems(List<Item> items)
        {
            Console.WriteLine("\n\n------------------ ITEMS COLLECTION ------------------\n\n");
            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n\n------------------------------------\n\n");
        }

    }
}
