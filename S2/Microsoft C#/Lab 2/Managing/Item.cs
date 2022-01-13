using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing
{
    class Item
    {
        private int number;
        private string name ;
        private double price;
        private int quantity;

        public Item()
        {
            number = -1;
            name = "no name";
            price = 0;
            quantity = 0;
        }

        public Item(int number, string name, double price, int quantity)
        {
            this.number = number;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public Item(Item item)
        {
            number = item.number;
            name = item.name;
            price = item.price;
            quantity = item.quantity;
        }

        public string ToString()
        {
            string str = "\n- Hello I'm item n°" + number + " \n  My name is \'" 
                        + name + "\' and I cost " + price + "$" + "\n  There are still " 
                        + quantity +" of us remaining.\n";
            return str;
        }

        // Getters
        public int getNumber()
        {
            return number;
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        { return price; }

        public int getQuantity()
            { return quantity; }
            
        // Setters

        public void setName(string name)
        { this.name = name; }

        public void setPrice (double price)
            { this.price = price; }

        public void setQuantity( int quantity)
        { this.quantity = quantity; }
    }
}
