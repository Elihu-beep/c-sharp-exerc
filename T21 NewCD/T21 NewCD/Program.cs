using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T21_NewCD
{
    public class Cd
    {
        public string Artist { get; set; }
        public string Name { get; set; }

        public List<Song> songs = new List<Song>();
        public Cd(string artist, string name)
        {
            Artist = artist;
            Name = name;
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public int NumberOfSongs
        {
            get { return songs.Count; }
        }

        public TimeSpan TotalLength => new TimeSpan(songs.Sum(song => song.Length.Ticks));


        public string CdInfo()
        {
            string msg = "";
            foreach (var song in songs)
            {
                msg += song.ToString();
            }
            return $"Album: {Name}\nArtist: {Artist}\nNumber of Songs: {NumberOfSongs}\nTotal length: {TotalLength:mm\\:ss} min\n-------------------------- \n" + msg;
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public TimeSpan Length { get; set; }

        public Song(string  name, TimeSpan length) 
        {
            Name = name;
            Length = length;
        }

        public override string ToString()
        {
            return $"{Name}, {Length:mm\\:ss} min\n";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cd testiCd = new Cd("Room For Squares", "John Mayer");

            testiCd.AddSong(new Song("No Such Thing", new TimeSpan(0,3,51)));
            testiCd.AddSong(new Song("Why Georgia", new TimeSpan(0,4,29)));
            testiCd.AddSong(new Song("My Stupid Mouth", new TimeSpan(0,3,44)));
            testiCd.AddSong(new Song("Your Body is a Wonderland", new TimeSpan(0,4,10)));
            testiCd.AddSong(new Song("Neon", new TimeSpan(0,4,22)));
            testiCd.AddSong(new Song("City Love", new TimeSpan(0,4,0)));
            testiCd.AddSong(new Song("83", new TimeSpan(0,4,51)));
            testiCd.AddSong(new Song("3X5", new TimeSpan(0,4,49)));
            testiCd.AddSong(new Song("Love Song for No One", new TimeSpan(0,3,22)));
            testiCd.AddSong(new Song("Back to You", new TimeSpan(0,4,02)));
            testiCd.AddSong(new Song("Great Indoors", new TimeSpan(0,3,36)));
            testiCd.AddSong(new Song("Not Myself", new TimeSpan(0,3,37)));
            testiCd.AddSong(new Song("St. Patrick's Day", new TimeSpan(0,5,21)));

            Console.WriteLine(testiCd.CdInfo());
        }
    }
}
