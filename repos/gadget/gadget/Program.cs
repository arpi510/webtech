using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gadget
{


    class Gadget
    {
        // Private properties
        private int id;
        private string name;
        private double price;
        private string quality;
        private double discount;
        private double vat;

        // Constructor
        public Gadget(int id, string name, double price, string quality, double discount, double vat)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quality = quality;
            this.discount = discount;
            this.vat = vat;
        }

        // Set methods
        public void setId(int id) 
        { this.id = id; }
        public void setName(string name)
        { this.name = name; }
        public void setPrice(double price) 
        { this.price = price; }
        public void setQuality(string quality)
        { this.quality = quality; }
        public void setDiscount(double discount) 
        { this.discount = discount; }
        public void setVat(double vat)
        { this.vat = vat; }

       
        public int getId() { return this.id; }
        public string getName() 
        { return this.name; }
        public double getPrice()
        { return this.price; }
        public string getQuality()
        { return this.quality; }
        public double getDiscount()
        { return this.discount; }
        public double getVat() 
        { return this.vat; }

        
        public void show()
        {
            Console.WriteLine("Product ID: " + getId());
            Console.WriteLine("Product Name: " + getName());
            Console.WriteLine("Price: " + getPrice() + " BDT");
            Console.WriteLine("Quality: " + getQuality());
            Console.WriteLine("Discount: " + getDiscount() + "%");
            Console.WriteLine("VAT: " + getVat() + "%");
        }

        
        public double calculateTotalPrice(int quantity)
        {
            double discountedPrice = price - (price * discount / 100);
            double priceWithVat = discountedPrice + (discountedPrice * vat / 100);
            return priceWithVat * quantity;
        }
    }

    class Program
    {
        static void Main()
        {
            
            Gadget gadget = new Gadget(101, "Smartphone", 20000, "High", 10, 5);

            
            Console.WriteLine("Available Gadget:\n");
            gadget.show();

            
            Console.Write("\nEnter quantity you want to buy: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            
            double total = gadget.calculateTotalPrice(quantity);

            
            Console.WriteLine("\nTotal price (after discount and VAT) for " + quantity + " unit(s): " + total + " BDT");
            Console.ReadKey();
        }


    }
}
