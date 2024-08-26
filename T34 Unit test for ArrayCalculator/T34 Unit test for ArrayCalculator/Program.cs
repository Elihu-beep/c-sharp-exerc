using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T34_Unit_test_for_ArrayCalculator
{
    public class ArrayCalculator
    {
        public static double Sum(double[] array)
        {
            double sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static double Average(double[] array)
        {
            if (array.Length == 0)
                return 0;

            return Sum(array) / array.Length;
        }

        public static double Min(double[] array)
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Array is empty");

            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        public static double Max(double[] array)
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Array is empty");

            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            Console.WriteLine("Sum: " + ArrayCalculator.Sum(array));
            Console.WriteLine("Average: " + ArrayCalculator.Average(array));
            Console.WriteLine("Min: " + ArrayCalculator.Min(array));
            Console.WriteLine("Max: " + ArrayCalculator.Max(array));
        }
    }
}
