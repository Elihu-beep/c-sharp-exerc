using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T29_Cashier
{
    public interface ITransaction
    {
        string ShowTransaction();
        float Money { get; }
    }

    public class PaidWithCash : ITransaction
    {
        public float Money { get; private set; }

        public PaidWithCash(float amount)
        {
            Money = amount;
        }

        public string ShowTransaction()
        {
            return $"Paid with cash: {Money} Euros";
        }
    }

    public class PaidWithCard : ITransaction
    {
        public float Money { get; private set; }

        public PaidWithCard(float amount)
        {
            Money = amount;
        }

        public string ShowTransaction()
        {
            return $"Paid with card: {Money} Euros";
        }
    }

    public class CashMachine
    {
        private List<ITransaction> transactions = new List<ITransaction>();
        private float totalCash = 0;

        public void AddTransaction(ITransaction transaction)
        {
            transactions.Add(transaction);
            if (transaction is PaidWithCash)
            {
                totalCash += transaction.Money;
            }
        }

        public float ShowTotal()
        {
            return transactions.Sum(t => t.Money) - totalCash;
        }

        public float ShowCash()
        {
            return totalCash;
        }

        public float ShowTotalSales()
        {
            return transactions.Sum(t => t.Money);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CashMachine cashMachine = new CashMachine();

            cashMachine.AddTransaction(new PaidWithCash(100.0f));
            cashMachine.AddTransaction(new PaidWithCash(50.0f));
            cashMachine.AddTransaction(new PaidWithCard(78.95f));
            cashMachine.AddTransaction(new PaidWithCard(45.65f));

            Console.WriteLine($"Total money in bank account: {cashMachine.ShowTotal()} Euros");
            Console.WriteLine($"Total money in cash register: {cashMachine.ShowCash()} Euros");
            Console.WriteLine($"Total sales of the day: {cashMachine.ShowTotalSales()} transactions");
        }
    }

}
