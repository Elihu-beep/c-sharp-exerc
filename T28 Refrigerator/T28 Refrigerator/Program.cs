using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace T28_Refrigerator
{
    public class Food
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Food(string name, int quantity) 
        {
            Name = name;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name} {Quantity}";
        }
    }

    public class Refrigerator
    {
        public List<Food> foods { get; set; }

        public Refrigerator()
        {
            foods = new List<Food>();
        }

        public void AddItem(Food item)
        {
            foods.Add(item);
        }

        public void RemoveItem(string itemName)
        {
            foods.RemoveAll(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        }
        public void ListContents()
        {
            if (foods.Any())
            {
                Console.WriteLine("Refrigerator Contents:");
                foreach (var item in foods)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("The refrigerator is empty.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fridge = new Refrigerator();

            fridge.AddItem(new Food("Cheese", 1));
            fridge.AddItem(new Food("Fish", 2));
            fridge.AddItem(new Food("Potatoes", 6));

            fridge.ListContents();

            fridge.RemoveItem("Cheese");
            fridge.ListContents();
        }
    }

}
