using System;
using System.Collections.Generic;


namespace T11
{
    public class Cd
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public List<string> Songs { get; set; }


        public Cd(string artist, string album, string genre, int price, List<string> songs)
        {
            Artist = artist;
            Album = album;
            Genre = genre;
            Price = price;
            Songs = songs;
        }

        public string ShowInfo()
        {
            return $"CD Info:\nArtist: {Artist}\nAlbum: {Album}\nGenre: {Genre}\nPrice: {Price}\nSongs:\n-{string.Join("\n-", Songs)}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> songs = new List<string> {
                "No Such Thing", "Why Georgia", "My Stupid Mouth", "Your Body Is a Wonderland",
                "Neon", "City Love", "83", "Love Song for No One", "Back to You", "Great Indoors",
                "Not Myself", "St. Patrick's Day"
            };

            Cd cd1 = new Cd("John Mayer", "Room for Squares", "Pop", 10, songs);

            Console.WriteLine(cd1.ShowInfo());

        }
    }
}
