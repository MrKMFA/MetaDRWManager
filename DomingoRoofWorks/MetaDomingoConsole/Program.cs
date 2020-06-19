using MetaDomingoLibrary.Models.Derived;
using System;

namespace MetaDomingoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer kenneth = new Customer();

            Console.WriteLine(kenneth.CustomerId);
            Console.WriteLine(kenneth.PersonId);
            Console.WriteLine(kenneth.EntityId);
            Console.WriteLine(kenneth.CreatedAt);

            Console.ReadLine();
        }
    }
}
