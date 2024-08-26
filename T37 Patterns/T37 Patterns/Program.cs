using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T37_Patterns
{
    abstract class Shape
    {
        public string Name { get; set; }

        public abstract double Area();
        public abstract double Circumference();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Circumference()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Circumference()
        {
            return 2 * (Width + Height);
        }
    }

    class Shapes
    {
        private List<Shape> shapesList;

        public Shapes()
        {
            shapesList = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shapesList.Add(shape);
        }

        public void PrintAllShapes()
        {
            foreach (Shape shape in shapesList)
            {
                if (shape is Circle)
                {
                    Circle circle = shape as Circle;
                    Console.WriteLine($"Circle Radius= {Math.Round(circle.Radius, 2)}, Area= {Math.Round(shape.Area(), 2)} Circumference: {Math.Round(shape.Circumference(), 2)}");
                }
                else if (shape is Rectangle)
                {
                    Rectangle rectangle = shape as Rectangle;
                    Console.WriteLine($"Rectangle Width= {Math.Round(rectangle.Width)} Height= {Math.Round(rectangle.Height),2} Area= {Math.Round(shape.Area(), 2)} Circumference= {Math.Round(shape.Circumference(), 2)}");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Shapes shapes = new Shapes();

                Circle circle1 = new Circle(1);
                Circle circle2 = new Circle(2);
                Circle circle3 = new Circle(3);

                Rectangle rectangle1 = new Rectangle(10, 20);
                Rectangle rectangle2 = new Rectangle(20, 30);
                Rectangle rectangle3 = new Rectangle(40, 50);

                shapes.AddShape(circle1);
                shapes.AddShape(circle2);
                shapes.AddShape(circle3);
                shapes.AddShape(rectangle1);
                shapes.AddShape(rectangle2);
                shapes.AddShape(rectangle3);

                shapes.PrintAllShapes();
            }
        }
    }
}
