using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18_Student_goods
{
    public class Bookshelf
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Bookshelf(string type ,string name, int year) 
        {
            Type = type;
            Name = name;
            Year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Type: {Type}, Name: {Name}, Year: {Year}");
        }
    }

    public class Book : Bookshelf
    {
        public string Author { get; set; }
        public int NumberofPages { get; set; }

        public Book(string type, string name, int year, string author, int numberofPages) : base(type, name, year)
        {
            Author = author;
            NumberofPages = numberofPages;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Author: {Author}, Number of pages: {NumberofPages}");
        }
    }

    public class Disc : Bookshelf
    {
        public string Genre { get; set; }
        public int Runtime { get; set; }

        public Disc(string type, string name, int year, string genre, int runtime) : base(type, name, year)
        {
            Genre = genre;
            Runtime = runtime;

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Genre: {Genre}, Runtime: {Runtime} minutes");
        }

    }
    public class Device : Bookshelf
    {
        public Double ScreenSize { get; set; }
        public int Memory { get; set; }

        public Device(string type, string name, int year, Double screenSize, int memory) : base(type, name, year)
        {
            ScreenSize = screenSize;
            Memory = memory;

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ScreenSize: {ScreenSize} inches, Memory: {Memory} gigabytes");
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Manga", "Dragon Ball", 1984, "Akira Toriyama", 200);
            book.ShowInfo();
            Console.WriteLine();

            Disc disc = new Disc("Bluray", "Poor Things", 2023, "Black comedy", 142);
            disc.ShowInfo();
            Console.WriteLine();

            Device device = new Device("Phone", "Apple IPhone", 2021, 6.1, 128);
            device.ShowInfo();
            Console.WriteLine();

        }
    }
}
