using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20_Mammal
{
    public abstract class Mammal
    {
        public int Age { get; set; }

        public abstract void Move();

        public Mammal(int age) 
        {
            Age = age;
        }
    }

    public class Human : Mammal
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }

        public Human(string name, int age, float weight, float height) : base(age)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Grow()
        {
            Age++;
        }
    }

    public class Baby : Human
    {
        public string Diaper { get; set; }

        public Baby(string name, int age, float weight, float height, string diaper) : base(name, age, weight, height)
        {
            Diaper = diaper;
        }

        public override void Move()
        {
            Console.WriteLine("Crawling");
        }
    }

    public class Adult : Human
    {
        public string Auto { get; set; }

        public Adult(string name, int age, float weight, float height, string auto) : base(name, age, weight, height)
        {
            Auto = auto;
        }

        public override void Move()
        {
            Console.WriteLine("Walking");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Baby baby = new Baby("Bob", 1, 7.5f, 0.6f, "Disposable");
            Adult adult = new Adult("Juha", 25, 75.0f, 1.8f, "Car");


            Console.WriteLine("Baby:");
            Console.WriteLine($"Name: {baby.Name}, Age: {baby.Age}, Weight: {baby.Weight}, Height: {baby.Height}, Diaper: {baby.Diaper}");
            baby.Move();
            baby.Grow(); 
            Console.WriteLine($"Age after growing: {baby.Age}");

            Console.WriteLine("\nAdult:");
            Console.WriteLine($"Name: {adult.Name}, Age: {adult.Age}, Weight: {adult.Weight}, Height: {adult.Height}, Auto: {adult.Auto}");
            adult.Move();
            adult.Grow();
            Console.WriteLine($"Age after growing: {adult.Age}");
        }
    }
}
