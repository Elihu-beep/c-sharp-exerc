using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviestars
{
    public class Human
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Human(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
        public override string ToString()
        {
            return $"{Name} {BirthYear}\n";
        }
    }
    public class Actor : Human
    {
        public Actor(string name, int birthYear) : base(name, birthYear)
        {
        }
    }
    public class Director : Human
    {
        public Director(string name, int birthYear) : base(name, birthYear)
        {
        }
    }

    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Director Director { get; }
        public List<Actor> actors { get; }

        public Movie(string name, int year, Director director)
        {
            Name = name;
            Year = year;
            Director = director;
            actors = new List<Actor>();
        }

        public void AddActor(Actor actor)
        {
            actors.Add(actor);
        }

        public string MovieInfo()
        {
            string msg = "";
            foreach (var actor in actors)
            {
                msg += actor.ToString();
            }
            return $"Movie: {Name}, Year: {Year}, Director: {Director}Actors:\n" + msg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director("Paul King", 1978);
            Movie movie = new Movie("Wonka", 2023, director);
            movie.AddActor(new Actor("Timothée Chalamet", 1995));
            movie.AddActor(new Actor("Hugh Grant", 1960));

            Director director2 = new Director("Christopher Nolan", 1970);
            Movie movie2 = new Movie("Interstellar", 2014, director2);
            movie2.AddActor(new Actor("Matthew McConaughey", 1969));
            movie2.AddActor(new Actor("Jessica Chastain", 1977));

            Console.WriteLine(movie.MovieInfo());
            Console.WriteLine(movie2.MovieInfo());
        }
    }
}
