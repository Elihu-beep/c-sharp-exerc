using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Vehicle
{
    public class Tire
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string TireSize { get; set; }

        public Tire(string manufacturer, string model, string tireSize) 
        {
            Manufacturer = manufacturer;
            Model = model;
            TireSize = tireSize;
        }

        public override string ToString()
        {
            return $"Tire: {Manufacturer} {Model} {TireSize}";
        }
    }

    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public List<Tire> tires = new List<Tire>();

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void AddTires(Tire tire)
        {
            tires.Add(tire);
        }

        public string VehicleInfo()
        {
            string msg = "";
            foreach (Tire t in tires)
            {
                msg += t.ToString() + "\n";
            }
            return $"Vehicle: {Brand} {Model}" + "\n" + msg;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle("Audi", "A4");
            car1.AddTires(new Tire("Nokia", "Hakkapeliitta ", "205R16"));
            car1.AddTires(new Tire("Nokia", "Hakkapeliitta ", "205R16"));
            car1.AddTires(new Tire("Nokia", "Hakkapeliitta ", "205R16"));
            car1.AddTires(new Tire("Nokia", "Hakkapeliitta ", "205R16"));

            Vehicle car2 = new Vehicle("Toyota", "Corolla");
            car2.AddTires(new Tire("Hankook", "Kinergy", "195/65R15"));
            car2.AddTires(new Tire("Hankook", "Kinergy", "195/65R15"));
            car2.AddTires(new Tire("Hankook", "Kinergy", "195/65R15"));
            car2.AddTires(new Tire("Hankook", "Kinergy", "195/65R15"));

            Console.WriteLine(car1.VehicleInfo());
            Console.WriteLine(car2.VehicleInfo());
        }
    }
}
