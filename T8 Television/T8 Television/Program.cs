using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTC8840
{
    public class TV
    {
        public bool IsOn = true;
        public int Volume { get; set; }
        public int Channel { get; set; }
        public int Brightness { get; set; }
        public int Contrast {  get; set; }
        public void SwitchOn()
        {
            IsOn = false;
        }

        public TV()
        {
            Volume = 10;
            Channel = 1;
            Brightness = 5;
            Contrast = 5;
        }

        public void IncreaseVolume()
        {
            if (Volume < 30) {
                Volume = Volume + 5;
            }       
        }
        public void DecreaseVolume()
        {
            if (Volume > 0)
            {
                Volume = Volume - 5;
            }
        }

        public void ChangeChannel()
        {
            if (Channel >= 6)
            {
                Channel = 1;
            } else
            {
                Channel = Channel + 1;
            }
        }

        public void ChangeContrast()
        {
            if (Contrast >= 10)
            {
                Contrast = 1;
            }
            else
            {
                Contrast = Contrast + 1;
            }
        }

        public void ChangeBrightness()
        {
            if (Brightness >= 10)
            {
                Brightness = 1;
            }
            else
            {
                Brightness = Brightness + 1;
            }
        }
        public string ShowAllData()
        {
            string msg = "";
            msg = $"Channel: [{Channel}] ,Volume: [{Volume}], Brightness: [{Brightness}], Contrast: [{Contrast}]";
            return msg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TV session = new TV();
            Console.WriteLine(@"
You can switch between channels by typing 'Channel'.
You can change volume by typing 'increase' or 'decrease'.
You can change contrast by typing 'contrast'.
You can change brightness by typing 'brightness'.
You can turn off the tv by typing 'shut'.");

            while (true)
            {
                Console.WriteLine(session.ShowAllData());

                string Input = Console.ReadLine();

                if (Input == "shut")
                {
                    session.SwitchOn();
                    break;
                }

                else if (Input == "channel")
                {
                    session.ChangeChannel();
                }
                else if (Input == "increase")
                {
                    session.IncreaseVolume();
                }
                else if (Input == "decrease")
                {
                    session.DecreaseVolume();
                }
                else if (Input == "contrast")
                {
                    session.ChangeContrast();
                }
                else if (Input == "brightness")
                {
                    session.ChangeBrightness();
                }
                else 
                {
                    Console.WriteLine("Incorrect value! Please enter another value: ");
                }

            }
        }
    }
}