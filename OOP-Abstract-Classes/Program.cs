using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract classes = modifier that indicates components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            Vehicle vehicle = new Vehicle();


            Console.ReadKey();
        }
    }
    // to prevent people from istantiating incomplete class
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        int MaxSpeed = 100;
    }
}