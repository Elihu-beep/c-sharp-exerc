using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_Employee
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public decimal Salary { get; set; }
        
        public Employee(string name, string profession, int salary) 
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Profession: {Profession}, Salary: {Salary}");
        }
    }

    class Boss : Employee
    {
        public string Car { get; set; }
        public decimal Bonus { get; set; }

        public Boss(string name, string profession, int salary, string car, decimal bonus)
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Car: {Car}, Bonus: {Bonus}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Sirpa", "Lääkäri", 10000);
            Console.WriteLine("Employee details: ");
            employee.ShowInfo();
            Console.WriteLine();

            Boss boss = new Boss("Anni", "Lakimies", 8000, "Audi", 3000);
            Console.WriteLine("Boss details: ");
            boss.ShowInfo();
            Console.WriteLine();

        }
    }
}
