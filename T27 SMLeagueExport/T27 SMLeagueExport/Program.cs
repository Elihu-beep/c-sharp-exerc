using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace T26_SMLeague
{

    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int Number { get; set; }

        public Player(string firstName, string lastName, string role, int number)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Number = number;
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {Role}, #{Number}";
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Hometown { get; set; }
        public List<Player> Players { get; set; }

        public Team(string team)
        {
            Players = new List<Player>();

            switch (team)
            {
                case "Kärpät":
                    Name = "Kärpät";
                    Hometown = "Oulu";
                    Players.Add(new Player("Marko", "Anttila", "Right Wing", 6));
                    break;

                    //Tähän vois lisätä eri joukkueille omat tapaukset
            }
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
        public void DeletePlayer(string firstName, string lastName)
        {
            Players.RemoveAll(p => p.FirstName == firstName && p.LastName == lastName);
        }

        public void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var kärpät = new Team("Kärpät");
            kärpät.AddPlayer(new Player("Niclas", "Westerholm", "Goalie", 53));
            kärpät.ListPlayers();
            string filePath = @"C:\Users\Elias\Documents\Koulu\Kurssit\OOP\T27 SMLeagueExport\testi.csv";
            SaveToCsv(kärpät.Players, filePath);
            Console.WriteLine("Team data saved to CSV file.");
        }

        private static void SaveToCsv(List<Player> players, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (Player player in players)
                {
                    writer.WriteLine(player.ToString());
                }
            }
        }
    }
}
