using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public struct Person{

        public string Name;
        public int YearOfBirth;

    }

    static void Main()
    {
        List<Person> people = new List<Person>();
        Console.WriteLine("Please, give names and birth year of a person. Empty input will stop the input.");

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;

            var parts = input.Split(',');
            if (parts.Length != 2 || !int.TryParse(parts[1], out int yearOfBirth))
            {
                Console.WriteLine("Invalid format");
                continue;
            }
            var person = new Person
            {
                Name = parts[0],
                YearOfBirth = yearOfBirth
            };
            people.Add(person);
        }

        var sortedPeople = people.OrderByDescending(p => p.YearOfBirth).ToList();

        Console.WriteLine($"Total names entered: {people.Count}");

        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"{person.Name} is {2024 - (person.YearOfBirth)} years old.");
        }
    }
}
