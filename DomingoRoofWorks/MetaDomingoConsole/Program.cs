using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.Derived;
using System;

namespace MetaDomingoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessEntity businessEntity = new Vendor();
            //Vendor vendor = new Vendor();

            //Customer customer = new Customer();
            //Employee employee = new Employee();
            //Jobtype jobtype = new Jobtype();

            //Jobcard jobcard = new Jobcard(employee, customer, jobtype);

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(businessEntity);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(vendor);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(customer);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(employee);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(jobtype);
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(jobcard);
            //Console.WriteLine("-----------------------------------");

            Customer customer = new Customer();
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer();

            Console.WriteLine(customer.EntityId);
            Console.WriteLine(customer1.EntityId);
            Console.WriteLine(customer2.EntityId);
            Console.WriteLine(customer3.EntityId);
            Console.WriteLine(customer4.EntityId);
            Console.WriteLine(customer.PersonId);
            Console.WriteLine(customer1.PersonId);
            Console.WriteLine(customer2.PersonId);
            Console.WriteLine(customer3.PersonId);
            Console.WriteLine(customer4.PersonId);
            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer1.CustomerId);
            Console.WriteLine(customer2.CustomerId);
            Console.WriteLine(customer3.CustomerId);
            Console.WriteLine(customer4.CustomerId);

            //Employee lorenzo = new Employee();

            //Console.WriteLine(lorenzo);

            Console.ReadLine();
        }
    }
}
