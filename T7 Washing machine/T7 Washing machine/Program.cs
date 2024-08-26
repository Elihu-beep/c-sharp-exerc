using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTC8840
{
    public class WashingMachine
    {
        public bool MachineState = false;
        public int Temperature { get; set; }
        public int SpinSpeed { get; set; }

        public bool PreWash = false;

        public WashingMachine()
        {
            Temperature = 40;
            SpinSpeed = 1200;
        }

        public void SwitchOn()
        {
            MachineState = true;
        }

        public void SwitchPreWash()
        {
            PreWash = true;
        }
        public void AdjustTemperature(int newTemperature)
        {
            Temperature = newTemperature;
        }

        public void AdjustSpeed(int newSpeed)
        {
            SpinSpeed = newSpeed;
        }
        public string ShowAllData()
        {
            string msg = "";
            msg = $"Washing machine is on({MachineState}), pre-wash is on ({PreWash}), temperature is set to {Temperature} and spinspeed is set to {SpinSpeed}.";
            return msg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WashingMachine program1 = new WashingMachine();
            program1.SwitchOn();
            program1.AdjustTemperature(30);
            program1.AdjustSpeed(800);

            WashingMachine program2 = new WashingMachine();
            program2.SwitchOn();
            program2.SwitchPreWash();
            program2.AdjustTemperature(60);
            program2.AdjustSpeed(1400);

            Console.WriteLine("For program 1: " + program1.ShowAllData());
            Console.WriteLine("For program 2: " + program2.ShowAllData());
        }
    }
}