using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.Derived;
using System;

namespace MetaDomingoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessEntity businessEntity = new Vendor();
            Vendor vendor = new Vendor();

            Customer customer = new Customer();
            Employee employee = new Employee();
            Jobtype jobtype = new Jobtype();

            Jobcard jobcard = new Jobcard(employee, customer, jobtype);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(businessEntity);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(vendor);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(customer);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(employee);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(jobtype);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(jobcard);
            Console.WriteLine("-----------------------------------");

            Console.ReadLine();
        }
    }
}
