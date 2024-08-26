using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using T23_Queue;
using static T23_Queue.CheckOutQueue;

namespace T23_Queue
{
    public class CheckOutQueue
    {
        public Queue<Customer> customers= new Queue<Customer>();

        public void GoTo(Customer customer)
        {
            customers.Enqueue(customer);
        }
        public void Exit()
        {
            customers.Dequeue();
        }

        public int Length
        {
            get { return customers.Count; }
        }

        public string QueueInfo()
        {
            return $"Queue length: {Length}\n";
        }

        public class Customer
        {
            public string Name { get; set; }

            public Customer(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return $"{Name}";
            }

    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckOutQueue myQueue = new CheckOutQueue();
    
            while (true)
            {
                Console.WriteLine(myQueue.QueueInfo());
                string Input = Console.ReadLine();

                if (Input == "")
                {
                    break;
                }

                else if (string.IsNullOrWhiteSpace(Input) || int.TryParse(Input, out int _))
                {
                    Console.WriteLine("Invalid name!");
                }
               
                else
                {
                    myQueue.GoTo(new Customer(Input));
                }

            }

            while (myQueue.customers.Count > 0)
            {
                var customer = myQueue.customers.Peek();
                Console.WriteLine("---Serving the first customer---");
                Console.WriteLine($"Serving {customer.Name}");
                myQueue.Exit();
            }

            if (myQueue.customers.Count == 0)
            {
                Console.WriteLine("All customers have been served");
            }
        }
    }
}
