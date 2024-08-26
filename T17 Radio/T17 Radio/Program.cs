using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17_Radio
{
    public class ElectricalDevice
    {
        public bool On { get; set; }
        public float Power { get; set; }

        public ElectricalDevice(bool on, float power)
        {
            On = on;
            Power = power;
        }
    }

    public class PortableRadio : ElectricalDevice
    {
        private int volume;
        private float frequency;

        public int Volume
        {
            get { return volume; }
            set
            {
                if (On)
                    volume = value;
                else
                    Console.WriteLine("Turn on the radio to adjust volume.");
            }
        }

        public float Frequency
        {
            get { return frequency; }
            set
            {
                if (On)
                {
                    if (value >= 2000.0 && value <= 26000.0)
                        frequency = value;
                    else
                        Console.WriteLine("Invalid frequency. Frequency must be between 2000.0 and 26000.0.");
                }
                else
                    Console.WriteLine("Turn on the radio to adjust frequency.");
            }
        }

        public PortableRadio(bool on, float power) : base(on, power)
        {
            volume = 0;
            frequency = 2000.0f;
        }

        public override string ToString()
        {
            return $"On: {On}, Power: {Power} watts, Volume: {Volume}, Frequency: {Frequency}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Testing the portable radio
            PortableRadio radio = new PortableRadio(false, 10.0f);
            Console.WriteLine(radio);

            // Turning on the radio
            radio.On = true;
            Console.WriteLine(radio);

            // Adjusting volume and frequency
            radio.Volume = 5;
            radio.Frequency = 12000.0f;
            Console.WriteLine(radio);

            // Attempting to set volume and frequency when radio is off
            radio.On = false;
            radio.Volume = 3;
            radio.Frequency = 15000.0f;
        }
    }





}