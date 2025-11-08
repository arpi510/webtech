using System;
using System.Collections.Generic;

namespace CarSpeedApp
{
    public class CarSpeed
    {
        private float acceleration;
        private string engineNumber;

        // Constructor
        public CarSpeed(float acceleration = 0, string engineNumber = "")
        {
            this.acceleration = acceleration;
            this.engineNumber = engineNumber;
        }

        // Setter for engine number
        public void SetEngineNumber(string engineNumber)
        {
            this.engineNumber = engineNumber;
        }

        // Getter for engine number
        public string GetEngineNumber()
        {
            return this.engineNumber;
        }

        // Setter for acceleration
        public void SetAcceleration(float acceleration)
        {
            this.acceleration = acceleration;
        }

        // Getter for acceleration
        public float GetAcceleration()
        {
            return this.acceleration;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<CarSpeed> cars = new List<CarSpeed>();

            Console.Write("How many cars' information do you want to provide? ");
            int numCars = int.Parse(Console.ReadLine());

            // Collect information for each car
            for (int i = 1; i <= numCars; i++)
            {
                Console.WriteLine($"\nEnter details for Car {i}:");
                CarSpeed car = new CarSpeed();

                Console.Write("Engine number: ");
                car.SetEngineNumber(Console.ReadLine());

                Console.Write("Acceleration: ");
                car.SetAcceleration(float.Parse(Console.ReadLine()));

                cars.Add(car);
            }

            Console.WriteLine("\nCar details have been recorded successfully.");

            // Search for car details
            while (true)
            {
                Console.Write("\nEnter the engine number to search for (or type 'exit' to quit): ");
                string engineNumber = Console.ReadLine();

                if (engineNumber.ToLower() == "exit")
                {
                    break;
                }

                CarSpeed foundCar = cars.Find(car => car.GetEngineNumber() == engineNumber);

                if (foundCar != null)
                {
                    Console.WriteLine("\nCar found:");
                    Console.WriteLine($"Engine Number: {foundCar.GetEngineNumber()}");
                    Console.WriteLine($"Acceleration: {foundCar.GetAcceleration():0.00}");
                }
                else
                {
                    Console.WriteLine("Car is not found in the system.");
                }
            }
        }
    }
}
