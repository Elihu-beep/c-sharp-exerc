using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16_Vehicle
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Vehicle(string name, string model, int year, string color) 
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Model: {Model}, Year Model: {Year}, Color: {Color}");
        }

    }

    class Bicycle : Vehicle
    {
        public bool HasGears { get; set; }
        public string GearModel { get; set; }

        public Bicycle(string name, string model, int year, string color, bool hasGears, string gearModel) : base(name, model, year, color) 
        {
            HasGears = hasGears;
            GearModel = gearModel;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Has gears: {HasGears}, Gear model: {GearModel}");
        }
    }

    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int NumberofSeats { get; set; }

        public Boat(string name, string model, int year, string color, string boatType, int numberofSeats) : base(name, model, year, color)
        {
            NumberofSeats = numberofSeats;
            BoatType = boatType;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Boat type: {BoatType}, Number of seats: {NumberofSeats}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle("Baana ", "Eira ", 2024, "Blue", true, "Nexus SG‐C6001");
            bicycle.ShowInfo();
            Console.WriteLine();

            Boat boat = new Boat("Buster", "LX", 2021, "Grey", "Console boat", 4);
            boat.ShowInfo();
            Console.WriteLine();
        }
    }
}
