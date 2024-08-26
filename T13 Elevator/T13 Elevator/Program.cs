using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13
{
    public class ElevatorController
    {
        private int Floor;

        public int CurrentFloor
        {
            get { return Floor; }
        }

        public bool GoTo(int floor, out string message)
        {
            if (floor < 1 || floor > 5)
            {
                message = "Invalid floor. Elevator can only go to floors 1-5.";
                return false;
            }

            Floor = floor;
            message = $"Elevator moved to floor {Floor}.";
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElevatorController elevator = new ElevatorController();

            while (true)
            {
                Console.Write("Enter the desired floor (1-5): ");
                if (int.TryParse(Console.ReadLine(), out int desiredFloor))
                {
                    string message;
                    if (elevator.GoTo(desiredFloor, out message))
                    {
                        Console.WriteLine(message);
                        Console.WriteLine($"The elevator is now on floor {elevator.CurrentFloor}.");
                    }
                    else
                    {
                        Console.WriteLine(message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                }
            }
        }
    }
}