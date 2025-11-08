using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CarSpeed
{
    // Data members
    private float acceleration;
    private string engineNumber;
    private bool start;

    // Constructor with default values
    public CarSpeed(float acceleration = 0, string engineNumber = "", bool start = false)
    {
        this.acceleration = acceleration;
        this.engineNumber = engineNumber;
        this.start = start;
    }

    // Method to start the car
    public void StartCar()
    {
        start = true;
        Console.WriteLine("Car started successfully.");
    }

    //  stop the car
    public void StopCar()
    {
        start = false;
        Console.WriteLine("Car stopped successfully.");
    }

    //  set acceleration
    public void SetAcceleration(float acceleration)
    {
        this.acceleration = acceleration;
        Console.WriteLine($"Acceleration set to: {acceleration}");
    }

    //  engine number
    public void SetEngineNumber(string engineNumber)
    {
        this.engineNumber = engineNumber;
        Console.WriteLine($"Engine number set to: {engineNumber}");
    }

    // Method to compute velocity
    public float GetVelocity(float time)
    {
        if (start)
        {
            float velocity = acceleration * time;
            return velocity;
        }
        else
        {
            Console.WriteLine("Start the car first, then retrieve velocity after acceleration.");
            return 0;
        }
    }
}
