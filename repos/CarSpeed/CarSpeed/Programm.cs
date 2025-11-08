using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm
{
    internal class Programm { }
}

public class Program

    {

        public static void Main(string[] args)

        {

            // Loop to repeat 3 times

            for (int i = 0; i < 3; i++)

            {

                // Create a CarSpeed instance

                CarSpeed car = new CarSpeed();

                //  engine number

                Console.Write("Enter the engine number: ");

                string engineNumber = Console.ReadLine();

                car.SetEngineNumber(engineNumber);

                //  for acceleration

                Console.Write("Enter the acceleration: ");

                float acceleration = float.Parse(Console.ReadLine());

                car.SetAcceleration(acceleration);

                // Prompt user for time

                Console.Write("Enter the time: ");

                float time = float.Parse(Console.ReadLine());

                // Start the car

                car.StartCar();

                // Compute and display velocity

                float velocity = car.GetVelocity(time);

                Console.WriteLine($"Computed Velocity: {velocity:F2}");

                // Stop the car

                car.StopCar();

            }

        }

    }



