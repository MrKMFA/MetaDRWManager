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

            Console.WriteLine(customer);
            Console.WriteLine(employee);

            Console.ReadLine();
        }
    }
}
