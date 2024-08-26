using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Player> Players { get; set;}

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
        }
    }
}
