using System;

namespace BookShopApp
{
    public class Book
    {
        private int bookId;
        private string bookName;
        private string authorName;
        private double price;
        private int quantity;

        public Book()
        {
            Console.WriteLine("Empty Constructor - Book");
        }

     
        public Book(int bookId, string bookName, string authorName, double price, int quantity)
        {
            Console.WriteLine("Parameterized Constructor - Book");
            this.bookId = bookId;
            this.bookName = bookName;
            this.authorName = authorName;
            this.price = price;
            this.quantity = quantity;
        }

        
        public void SetBookId(int bookId) => this.bookId = bookId;
        public void SetBookName(string bookName) => this.bookName = bookName;
        public void SetAuthorName(string authorName) => this.authorName = authorName;
        public void SetPrice(double price) => this.price = price;
        public void SetQuantity(int quantity) => this.quantity = quantity;

 
        public int GetBookId() => bookId;
        public string GetBookName() => bookName;
        public string GetAuthorName() => authorName;
        public double GetPrice() => price;
        public int GetQuantity() => quantity;

        
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
            Console.WriteLine($"{amount} books added. New quantity: {quantity}");
        }

        public void SellQuantity(int amount)
        {
            if (amount <= quantity)
            {
                quantity -= amount;
                Console.WriteLine($"{amount} books sold. Remaining quantity: {quantity}");
            }
            else
            {
                Console.WriteLine("Not enough stock to sell.");
            }
        }
    }

    public class BookShop
    {
        private string category;
        private Book book;

       
        public BookShop()
        {
            Console.WriteLine("Empty Constructor - BookShop");
        }

        
        public BookShop(string category, Book book)
        {
            this.category = category;
            this.book = book;
        }

       
        public void SetCategory(string category) => this.category = category;
        public void SetBook(Book book) => this.book = book;

        public string GetCategory() => category;
        public Book GetBook() => book;

       
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
          
            Book b1 = new Book();  
            Book b2 = new Book(101, "chokherbali", "Rabindranath tagore", 499.99, 20);  

            
            b1.SetBookId(100);
            b1.SetBookName("darjeeling tales");
            b1.SetAuthorName("abhishek bhowmick");
            b1.SetPrice(399.99);
            b1.SetQuantity(10);

           
            BookShop shop1 = new BookShop();  
            BookShop shop2 = new BookShop("story", b2); 

           
            shop1.SetCategory("story");
            shop1.SetBook(b1);

           
            Console.WriteLine("\n--- Shop 1 Details ---");
            shop1.ShowAll();

            Console.WriteLine("\n--- Shop 2 Details ---");
            shop2.ShowAll();

           
            Console.WriteLine("\n--- Adding Quantity to Book 1 ---");
            b1.AddQuantity(5);  // to add 5 books

            Console.WriteLine("\n--- Selling Quantity from Book 1 ---");
            b1.SellQuantity(3); 

         
            Console.WriteLine("\n--- Final Shop 1 Book Info ---");
            shop1.ShowAll();

            Console.ReadKey();
        }
    }
}





