using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace T39_Timer
{
    class Timer
    {
        private int _totalSeconds;
        private string _alarmMessage;

        public Timer(int totalSeconds, string alarmMessage = "Wake wake, the little bird")
        {
            _totalSeconds = totalSeconds;
            _alarmMessage = alarmMessage;
        }

        public void Start()
        {
            Console.WriteLine($"Timer set for {_totalSeconds / 60} minutes and {_totalSeconds % 60} seconds.");

            int milliseconds = _totalSeconds * 1000;
            Thread.Sleep(milliseconds);

            Console.WriteLine(_alarmMessage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time for the alarm in the following format (minutes:seconds):");
            string input = Console.ReadLine();

            string[] parts = input.Split(':');
            if (parts.Length == 2 && int.TryParse(parts[0], out int minutes) && int.TryParse(parts[1], out int seconds))
            {
                int totalSeconds = minutes * 60 + seconds;
                if (totalSeconds >= 1 && totalSeconds <= 3600)
                {
                    Timer timer = new Timer(totalSeconds);
                    timer.Start();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}