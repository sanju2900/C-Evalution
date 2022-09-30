
/*
 
 Write a C# program that implements an IVehicle interface with two methods, one for Drive of 
type void and another for Refuel of type bool. 
The Refuel method takes an input parameter of type integer with the amount of petrol/diesel to refuel. 
Then create a Car class with a builder that receives a parameter with the car's starting
fuel(petrol/diesel) amount and implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, if the fuel(petrol/diesel) is greater than 0. 
The Refuel method will increase the fuel(petrol/diesel) of the car and return true.

To carry out the tests, create an object of type Car with 0 of fuel(petrol/diesel) in the Main program 
and ask the user for an amount of fuel(petrol/diesel) to refuel, finally execute the Drive method of the car.
 
 */


using System;

public class FirstInterface
{
   
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving Started : ");
            }
            else
            {
                Console.WriteLine("There is no fuel in car please filled it then try :");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
    public static void Main(string[] args)
    {
        Car car = new Car(0);
        Console.Write("Enter the Petrol : ");
        int fuel = int.Parse(Console.ReadLine());
        if (car.Refuel(fuel))
        {
            car.Drive();
        }
    }

}