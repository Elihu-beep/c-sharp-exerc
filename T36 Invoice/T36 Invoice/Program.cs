using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T36_Invoice
{
    class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double Total => Price * Quantity;

        public override string ToString()
        {
            return $"{Name}\t\t${Price}\t\t{Quantity}\t\tTotal: ${Total}";
        }
    }

    class Invoice
    {
        public string Customer { get; set; }
        public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();

        public int ItemsCount => Items.Count;

        public int ItemsTogether
        {
            get
            {
                int count = 0;
                foreach (var item in Items)
                {
                    count += item.Quantity;
                }
                return count;
            }
        }

        public double CountTotal()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Total;
            }
            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice
            {
                Customer = "Kirsi Kernel",
                Items = new List<InvoiceItem>
            {
                new InvoiceItem { Name = "Milk", Price = 1.75, Quantity = 1 },
                new InvoiceItem { Name = "Beer", Price = 5.25, Quantity = 1 },
                new InvoiceItem { Name = "Butter", Price = 2.5, Quantity = 2 }
            }
            };

            Console.WriteLine(PrintInvoice(invoice));
        }

        private static string PrintInvoice(Invoice invoice)
        {
            string invoiceString = $"Customer: {invoice.Customer}\n";
            invoiceString += $"{"Name",-20}{"Price",-10}{"Quantity",-10}{"Total",-10}\n";
            foreach (var item in invoice.Items)
            {
                invoiceString += item.ToString() + "\n";
            }
            invoiceString += $"\nTotal Items: {invoice.ItemsTogether}\n";
            invoiceString += $"Total Amount: ${invoice.CountTotal()}";
            return invoiceString;
        }
    }
}