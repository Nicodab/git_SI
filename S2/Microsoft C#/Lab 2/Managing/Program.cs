using System;

namespace Managing
{
    class Program
    {
        static void Main(string [] args)
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
                        Console.WriteLine("\nWhich item do you want to modify ? ( type number of item)\n");
                        //Item it = findItem(list);
                        list = modifyItem(list);
                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    case 7:

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
            Console.WriteLine("Type in the number of the item you're looking for : ");
            int nb = int.Parse(Console.ReadLine());
            foreach (Item item in items)
            {
                if (nb == item.getNumber())
                {
                    return item;
                }

            }

            return null;
        }

        public static List<Item> modifyItem(List<Item> items)
        {
            Console.WriteLine("Type in the number of the item you're looking for : ");
            int nb = int.Parse(Console.ReadLine());
            foreach (Item item in items)
            {
                if (nb == item.getNumber())
                {
                    bool valid = true;
                    do
                    {
                        Console.WriteLine("\n1.Name\n2.Price\n3.Quantity\n");
                        Console.WriteLine("What do you want to modify ? ");
                        int modification = int.Parse(Console.ReadLine());
                        switch (modification)
                        {
                            case 1:
                                item.setName(Console.ReadLine());
                                break;
                            case 2:
                                item.setPrice(double.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                item.setQuantity(int.Parse(Console.ReadLine()));
                                break;
                            default:
                                valid = false;
                                Console.Write("\nPlease choose something to modify...\n");
                                break;
                        }
                    } while(valid);
                    
                    return items;
                }

            }
            Console.WriteLine("\nItem not found\n");
            return items;
        }
    }
}