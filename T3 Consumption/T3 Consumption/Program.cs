using System;

class Program
{

    static void calc(double distance)
    {
        Random rnd = new Random();
        double consumptionRnd = rnd.Next(6, 10);
        double fuelPriceRnd = rnd.NextDouble() * (2.5 - 1.75) + 1.75;
        double consumption = (consumptionRnd / 100) * distance;
        double fuelPrice = fuelPriceRnd * consumption;
        Console.WriteLine($"Fuel consumption is {consumption} litres and it costs {fuelPrice} euros");
    }

    static void Main()
    {
        Console.WriteLine("Enter distance driven: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        calc(distance);
    }



}

