using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T31_Random
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<Person> peopleList = new List<Person>();
            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                string firstName = GenerateRandomString(random, 4);
                string lastName = GenerateRandomString(random, 10);
                peopleList.Add(new Person(firstName, lastName));
            }

            stopwatch.Stop();
            long addTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time taken to add people: {addTime} ms");

            stopwatch.Restart();

            for (int i = 0; i < 1000; i++)
            {
                string randomFirstName = GenerateRandomString(random, 4);
                Person foundPerson = peopleList.Find(p => p.FirstName == randomFirstName);
                if (foundPerson != null)
                {
                    Console.WriteLine($"Person found: {foundPerson}");
                }
            }

            stopwatch.Stop();
            long searchTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time taken to search for people: {searchTime} ms");


            //With dictionary structure
            Console.WriteLine("-------------------------------------\nDICTIONARY");

            stopwatch.Reset();
            stopwatch.Start();

            Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();
            for (int i = 0; i < 10000; i++)
            {
                string firstName = GenerateUniqueRandomString(peopleDictionary, random, 4);
                string lastName = GenerateRandomString(random, 10);
                peopleDictionary.Add(firstName, new Person(firstName, lastName));
            }

            stopwatch.Stop();
            long addTime1 = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time taken to add people: {addTime1} ms");

            stopwatch.Restart();

            for (int i = 0; i < 1000; i++)
            {
                string randomFirstName = GenerateRandomString(random, 4);
                if (peopleDictionary.TryGetValue(randomFirstName, out Person foundPerson))
                {
                    Console.WriteLine($"Person found: {foundPerson}");
                }
            }

            stopwatch.Stop();
            long searchTime1 = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Time taken to search for people: {searchTime1} ms");


        }

        static string GenerateUniqueRandomString(Dictionary<string, Person> dictionary, Random random, int length)
        {
            string firstName;
            do
            {
                firstName = GenerateRandomString(random, length);
            } while (dictionary.ContainsKey(firstName));

            return firstName;
        }

        static string GenerateRandomString(Random random, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

//Nähdään, että ditrionarylla henkilöiden haku on paljon nopeampaa.
