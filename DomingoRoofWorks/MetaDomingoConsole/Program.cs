using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.Derived;
using System;

namespace MetaDomingoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Employee employee = new Employee();
            BusinessEntity businessEntity = new Vendor();
            Vendor vendor = new Vendor();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(customer);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(employee);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(businessEntity);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(vendor);
            Console.WriteLine("-----------------------------------");

            Console.ReadLine();
        }
    }
}
