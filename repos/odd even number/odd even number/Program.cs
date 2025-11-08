using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             

            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Even numbers from 1 to " + n + " are:");
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); 
            Console.ReadKey();
        }
        }
    }*/

            /* {
                 int sumEven = 0, sumOdd = 0;

                 for (int i = 1; i <= 100; i++)
                 {
                     if (i % 2 == 0) 
                         sumEven += i;
                     else 
                         sumOdd += i;
                 }

                 Console.WriteLine("Sum of even numbers : " + sumEven);
                 Console.WriteLine("Sum of odd numbers : " + sumOdd);
             }
         }*/

            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                double factorial = 1; 

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i; 
                }

                Console.WriteLine("Factorial of " + number + " is: " + factorial);
                Console.ReadKey();
            }
        }
    }
}


            