using System;
using System.Linq;

class Program
{
    public static void Points()
    {
        int[] pointsArr = new int[5];

        for (int i = 0; i < 5; i++) 
        {
            Console.WriteLine("Enter points: ");
            pointsArr[i] = Convert.ToInt32(Console.ReadLine());

        }

        int minValue = pointsArr.Min();
        int maxValue = pointsArr.Max();

        int[] newArr = pointsArr.Where(x => x != minValue && x != maxValue).ToArray();

        int sum = newArr.Sum();

        Console.WriteLine("Total points are: " + sum);

    }
    static void Main()
    {
        Points();
    }

}

