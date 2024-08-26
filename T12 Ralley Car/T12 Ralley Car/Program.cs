using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12
{
    public class RalleyCar
    {
        public string Name { get; set; }
        public string Type { get; set; }
        private float _speed;
        public float Speed
        {
            get { return _speed; }
            private set
            {
                if (value >= 0 && value <= SpeedMax)
                {
                    _speed = value;
                }
            }
        }
        public float SpeedMax { get; } = 200;

        public RalleyCar(string name, string type)
        {
            Name = name;
            Type = type;
            _speed = 0;
        }

        public void AccelerateTo(float speed)
        {
            if (speed >= 0 && speed <= SpeedMax)
            {
                _speed = speed;
                Console.WriteLine($"Accelerated to {speed} km/h.");
            }
            else
            {
                Console.WriteLine($"Speed should be between 0 and {SpeedMax} km/h.");
            }
        }

        public void SlowTo(float speed)
        {
            if (speed >= 0 && speed <= SpeedMax && speed <= _speed)
            {
                _speed = speed;
                Console.WriteLine($"Slowed down to {speed} km/h.");
            }
            else
            {
                Console.WriteLine($"Speed should be between 0 and {SpeedMax} km/h and less than or equal to current speed.");
            }
        }
    }

    class TestRalley
    {
        static void Main(string[] args)
        {
            RalleyCar car = new RalleyCar("Car1", "Sports");

            car.AccelerateTo(100);
            car.AccelerateTo(250);
            car.AccelerateTo(-50);

 
            car.SlowTo(50); 
            car.SlowTo(300); 
            car.SlowTo(150); 
        }
    }
}