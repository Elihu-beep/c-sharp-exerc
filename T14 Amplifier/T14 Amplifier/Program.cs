
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T14;

namespace T14
{
    public class Amplifier
    {
        private int Volume;

        public int CurrentVolume
        {
            get { return Volume; }
        }

        public bool SetTo(int volume, out string message)
        {
            if (volume < 0 || volume > 100)
            {
                message = "ERROR! Volume can only be between 1-100";
                return false;

            }
            Volume = volume;
            message = $"Volume is set to {Volume}.";
            return true;
        }
    }
}
class Program

{
    static void Main(string[] args)
    {
        Amplifier amplifier = new Amplifier();

        while (true)
        {
            Console.Write("Set volume (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int volume))
            {
                string message;
                if (amplifier.SetTo(volume, out message))
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}