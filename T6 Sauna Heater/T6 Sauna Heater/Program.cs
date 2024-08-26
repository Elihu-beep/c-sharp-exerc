using System;

namespace TTC8840
{
    public class Heater
    {
        public bool HeaterState = false;
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        public Heater()
        {
            Temperature = 5;
            Humidity = 5;
        }

        public void SwitchOn()
        {
            HeaterState = true;
        }
        public void AdjustTemperature(int newTemperature)
        {
            Temperature = newTemperature;
        }

        public void AdjustHumidity(int newHumidity)
        {
            Humidity = newHumidity;
        }
        public string ShowAllData()
        {
            string msg = "";
            msg = $"Sauna heater is on ({HeaterState}), temperature is set to {Temperature} and humidity is set to {Humidity}";
            return msg;
        }
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Heater stove = new Heater();
            stove.SwitchOn();
            stove.AdjustHumidity(10);
            stove.AdjustTemperature(10);
            Console.WriteLine(stove.ShowAllData());
        }
    }
}