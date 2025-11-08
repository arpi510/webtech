
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error! Division by zero.");
                break;
            default:
                Console.WriteLine("Invalid operator!");
                return;
        }

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}





