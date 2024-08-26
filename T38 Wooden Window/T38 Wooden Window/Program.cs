using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T38_Wooden_Window
{
    class Window
    {
        public double Width { get; }
        public double Height { get; }

        public Window(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            double frameArea = Width * Height;

            double glassArea = 3 * Width * Height;

            return frameArea + glassArea;
        }

        public double CalculateCircumference()
        {
            return 2 * (Width + Height);
        }

        public double CalculateWoodUsage(double woodThickness)
        {
            double frameLength = 2 * (Width + Height);
            return frameLength * woodThickness;
        }
        public double CalculateGlassUsage()
        {
            return CalculateArea() * 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the window:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the window:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the wood thickness:");
            double thickness = Convert.ToDouble(Console.ReadLine());

            Window window = new Window(width, height);

            Console.WriteLine($"Area of the window: {window.CalculateArea()} square m");
            Console.WriteLine($"Circumference of the window: {window.CalculateCircumference()}m");
            Console.WriteLine($"Wood usage: {window.CalculateWoodUsage(thickness)} square meters");
            Console.WriteLine($"Glass usage: {window.CalculateGlassUsage()} square meters");

            Console.ReadLine();
        }
    }
}
