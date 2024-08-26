using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// application needs to handle different vehicles: BICYCLE, MOTORCYCLE, CAR, TRUCK
// Vehicle class to represent vehicles

// Common vehicle characteristics: MANUFACTURER, MODEL, SPEED, AND NUMBER of tires
// Brand and model: string  & Speed and tires: int

// Method 1: Showinfo() which returns vehicle manufacturer and model information as a string
// Method 2: ToString() returns all vehicle properties as one string so you have to override base class ToString()

// Create at least couple of vehicle objects
// After creation change the objects properties anad print the objects information to the console using either method



namespace T9_Vehicle
{
    public enum VehicleType { Bicycle, Motorcycle, Car, Truck }
    public class Vehicle
    {
        public enum VehicleType { Bicycle, Motorcycle, Car, Truck }
        public VehicleType Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int NumberOfTires { get; set; }

        public Vehicle(string brand, string model, int speed, int tires)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
            NumberOfTires = tires;
        }

        public string ShowInfo()
        {
            return $"Brand: {Brand}, Model: {Model}";
        }
        public override string ToString()
        {
            return $"Vehicletype: {Type}, Brand: {Brand}, Model: {Model}, Speed {Speed}, Number of Tires: {NumberOfTires}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Audi", "A4", 220, 4);
            vehicle1.Type = Vehicle.VehicleType.Car;

            Vehicle vehicle2 = new Vehicle("Volvo", "FH16", 170, 6);
            vehicle2.Type = Vehicle.VehicleType.Truck;


            vehicle1.Speed = 235;
            vehicle1.Brand = "BMW";
            vehicle1.Model = "330";

            Console.WriteLine("Vechicle 1 info: " + vehicle1.ToString());
            Console.WriteLine("Vehicle 2 info: " + vehicle2.ShowInfo());

        }
    }
}
