using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }using System;

namespace BookShopApp
    {
        public class Book
        {
            private int bookId;
            private string bookName;
            private string authorName;
            private double price;
            private int quantity;

            // Empty Constructor
            public Book()
            {
                Console.WriteLine("Empty Constructor - Book");
            }

            // Parameterized Constructor
            public Book(int bookId, string bookName, string authorName, double price, int quantity)
            {
                Console.WriteLine("Parameterized Constructor - Book");
                this.bookId = bookId;
                this.bookName = bookName;
                this.authorName = authorName;
                this.price = price;
                this.quantity = quantity;
            }

            // Setters
            public void SetBookId(int bookId) => this.bookId = bookId;
            public void SetBookName(string bookName) => this.bookName = bookName;
            public void SetAuthorName(string authorName) => this.authorName = authorName;
            public void SetPrice(double price) => this.price = price;
            public void SetQuantity(int quantity) => this.quantity = quantity;

            // Getters
            public int GetBookId() => bookId;
            public string GetBookName() => bookName;
            public string GetAuthorName() => authorName;
            public double GetPrice() => price;
            public int GetQuantity() => quantity;

            // Show all book info
            public void ShowAll()
            {
                Console.WriteLine($"Book ID: {bookId}");
                Console.WriteLine($"Book Name: {bookName}");
                Console.WriteLine($"Author Name: {authorName}");
                Console.WriteLine($"Price: {price}");
                Console.WriteLine($"Quantity: {quantity}");
            }

            public void AddQuantity(int amount)
            {
                quantity += amount;
                Console.WriteLine($"{amount} books added. New Quantity: {quantity}");
            }

            public void SellQuantity(int amount)
            {
                if (amount <= quantity)
                {
                    quantity -= amount;
                    Console.WriteLine($"{amount} books sold. Remaining Quantity: {quantity}");
                }
                else
                {
                    Console.WriteLine("Not enough books in stock to sell.");
                }
            }
        }

        public class BookShop
        {
            private string category;
            private Book book;

            // Empty Constructor
            public BookShop()
            {
                Console.WriteLine("Empty Constructor - BookShop");
            }

            // Parameterized Constructor
            public BookShop(string category, Book book)
            {
                this.category = category;
                this.book = book;
            }

            // Setters
            public void SetCategory(string category) => this.category = category;
            public void SetBook(Book book) => this.book = book;

            // Getters
            public string GetCategory() => category;
            public Book GetBook() => book;

            // Show all bookshop info
            public void ShowAll()
            {
                Console.WriteLine($"Category: {category}");
                if (book != null)
                {
                    book.ShowAll();
                }
            }
        }

        public class Start
        {
            public static void Main(string[] args)
            {
                // Creating Book objects
                Book b1 = new Book(); // Empty constructor
                b1.SetBookId(1);
                b1.SetBookName("C# Basics");
                b1.SetAuthorName("Alan Turing");
                b1.SetPrice(500);
                b1.SetQuantity(10);

                Book b2 = new Book(2, "Advanced C#", "Dennis Ritchie", 800, 5); // Parameterized constructor

                // Creating BookShop objects
                BookShop shop1 = new BookShop(); // Empty constructor
                shop1.SetCategory("Programming");
                shop1.SetBook(b1);

                BookShop shop2 = new BookShop("Software Development", b2); // Parameterized constructor

                // Show all info
                Console.WriteLine("\n--- Shop 1 Details ---");
                shop1.ShowAll();

                Console.WriteLine("\n--- Shop 2 Details ---");
                shop2.ShowAll();

                // Call AddQuantity and SellQuantity
                Console.WriteLine("\n--- Updating Quantity for Book in Shop 2 ---");
                b2.AddQuantity(3);
                b2.SellQuantity(2);

                Console.WriteLine("\n--- Updated Shop 2 Details ---");
                shop2.ShowAll();

                Console.ReadKey();
            }
        }
    }

}
}
