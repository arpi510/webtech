using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;


class Book
{
    private string id;
    private string name;
    private double price;
    private int availableQuantity;

   
    public Book()
    {
        id = "Arpita101";
        name = "sunshine";
        price = 235;
        availableQuantity = 100;
    }

    public Book(string id, string name, double price, int availableQuantity)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.availableQuantity = availableQuantity;
    }

    // Set methods
    public void SetId(string id)
    {
        this.id = id;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void SetAvailableQuantity(int availableQuantity)
    {
        this.availableQuantity = availableQuantity;
    }

    // Get methods
    public string GetId()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetAvailableQuantity()
    {
        return availableQuantity;
    }


    public void AddQuantity(int amount)
    {
        availableQuantity += amount;
    }

    
    public void ShowDetails()
    {
        Console.WriteLine("Book ID: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Available Quantity: " + availableQuantity);
        Console.WriteLine("---------------------------");
    }
}

class Program
{
    static void Main()
    {
       
        Book book1 = new Book();
        Console.WriteLine("Book 1 :");
        book1.ShowDetails();

       
        Book book2 = new Book("Boo202", "Game of thrones", 299.99, 20);
        Console.WriteLine("Book 2 :");
        book2.ShowDetails();

      
        book1.AddQuantity(10);
        book2.AddQuantity(5);

      
        Console.WriteLine("After Adding Quantity:");
        Console.WriteLine("Book 1:");
        book1.ShowDetails();

        Console.WriteLine("Book 2:");
        book2.ShowDetails();

        Console.ReadLine();
    }
}


