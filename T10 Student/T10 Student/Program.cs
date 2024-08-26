using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_Student
{
    public class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public int Age { get; set; }

        public Student(string name, string major, int age)
        {
            Name = name;
            Major = major;
            Age = age;
        }
        public string ShowInfo()
        {
            return $"name: {Name}, major: {Major}, age: {Age}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Joey", "Acting", 25));
            students.Add(new Student("Chandler", "Mathematics", 26));
            students.Add(new Student("Monica", "Hospitality managment", 24));
            students.Add(new Student("Ross", "History", 26));
            students.Add(new Student("Rachel", "Marketing", 24));
            students.Add(new Student("Phoebe", "Music", 26));

            Console.WriteLine("STUDENT INFORMATION");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ShowInfo());
            }
        }
    }
}
