using MetaDomingoLibrary.Models.Derived;
using System;

namespace MetaDomingoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer kenneth = new Customer();

            //Console.WriteLine(kenneth.CustomerId);
            //Console.WriteLine(kenneth.PersonId);
            //Console.WriteLine(kenneth.EntityId);
            //Console.WriteLine(kenneth.CreatedAt);

            CustomerInvoice obj = new CustomerInvoice(kenneth);
            Console.WriteLine(obj.CustomerInvoiceId);
            Console.WriteLine(obj.InvoiceId);
            Console.WriteLine(obj.Customer.EntityId);
            Console.WriteLine(obj.Customer.PersonId);
            Console.WriteLine(obj.Customer.CustomerId);
            Console.WriteLine(obj.CreatedAt);
            Console.WriteLine(obj.ModifiedDate);

            Console.ReadLine();
        }
    }
}
