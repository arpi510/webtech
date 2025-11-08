using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arpita
{
    internal class Program
    {
        static void Main(string[] args)
        {
        } }


namespace ConsoleApp1
    {

        public class Account
        {
            private int accountNumber;
            private string accountHolderName;
            private double balance;

            // Empty constructor
            public Account()
            {
                Console.WriteLine("Empty Constructor-Account");
            }

            // Parameterized constructor
            public Account(int accountNumber, string accountHolderName, double balance)
            {
                Console.WriteLine("Para Constructor-Account");
                this.accountNumber = accountNumber;
                this.accountHolderName = accountHolderName;
                this.balance = balance;
            }

            // Getters and setters
            public void SetAccountNumber(int accountNumber) => this.accountNumber = accountNumber;
            public void SetAccountHolderName(string accountHolderName) => this.accountHolderName = accountHolderName;
            public void SetBalance(double balance) => this.balance = balance;

            public int GetAccountNumber() => accountNumber;
            public string GetAccountHolderName() => accountHolderName;
            public double GetBalance() => balance;

            // Show account information
            public void ShowInfo()
            {
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Account Holder Name: {accountHolderName}");
                Console.WriteLine($"Account Balance: {balance}");
            }
        }

        public class Customer
        {
            private string name;
            private int nid;
            private Account account;

            // Empty constructor
            public Customer()
            {
                Console.WriteLine("Empty Constructor-Customer");
            }

            // Parameterized constructor
            public Customer(string name, int nid, Account account)
            {
                this.name = name;
                this.nid = nid;
                this.account = account;
            }

            // Getters and setters
            public void SetName(string name) => this.name = name;
            public void SetNid(int nid) => this.nid = nid;
            public void SetAccount(Account account) => this.account = account;

            public string GetName() => name;
            public int GetNid() => nid;
            public Account GetAccount() => account;

            // Show customer details
            public void ShowDetails()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"NID: {nid}");
                if (account != null)
                {
                    Console.WriteLine($"Account Number: {account.GetAccountNumber()}");
                    Console.WriteLine($"Account Holder Name: {account.GetAccountHolderName()}");
                    Console.WriteLine($"Balance: {account.GetBalance()}");
                }
            }
        }

        public class Start
        {
            public static void Main(string[] args)
            {
                // Creating accounts
                Account a1 = new Account(111, "Alan", 100);
                Account a2 = new Account(112, "Alex", 200);
                Account a3 = new Account(113, "A", 300);


                // Creating customers
                Customer c1 = new Customer();
                Customer c2 = new Customer();
                Customer c3 = new Customer("ast", 2345, a3);

                // Setting details for customers
                c1.SetName("asd");
                c1.SetNid(1234);
                c1.SetAccount(a1);

                c2.SetName("zxc");
                c2.SetNid(5678);
                c2.SetAccount(a2);

                // Displaying customer details
                Console.WriteLine("Name: " + c1.GetName());
                Console.WriteLine("NID: " + c1.GetNid());
                Console.WriteLine("Account Number: " + c1.GetAccount().GetAccountNumber());
                Console.WriteLine("Account Holder Name: " + c1.GetAccount().GetAccountHolderName());
                Console.WriteLine("Balance: " + c1.GetAccount().GetBalance());

                Console.WriteLine("----------------------------");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Name: " + c2.GetName());
                Console.WriteLine("NID: " + c2.GetNid());
                Console.WriteLine("Account Number: " + c2.GetAccount().GetAccountNumber());
                Console.WriteLine("Account Holder Name: " + c2.GetAccount().GetAccountHolderName());
                Console.WriteLine("Balance: " + c2.GetAccount().GetBalance());

                Console.WriteLine("----------------------------");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Name: " + c3.GetName());
                Console.WriteLine("NID: " + c3.GetNid());
                Console.WriteLine("Account Number: " + c3.GetAccount().GetAccountNumber());
                Console.WriteLine("Account Holder Name: " + c3.GetAccount().GetAccountHolderName());
                Console.WriteLine("Balance: " + c3.GetAccount().GetBalance());

                Console.WriteLine("----------------------------");
                Console.WriteLine("----------------------------");
                c3.ShowDetails();

                Console.ReadKey();
            }
        }



    }
}
}

