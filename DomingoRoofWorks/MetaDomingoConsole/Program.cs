using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.Derived;
using System;
using System.Collections.Generic;

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
            Customer madeleine = new Customer();

            Jobcard jobcard = new Jobcard(employee, customer, jobtype);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(madeleine);
            Console.WriteLine("-----------------------------------");
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


            //Employee lorenzo = new Employee();

            //Console.WriteLine(lorenzo);
            //List<Customer> list = new List<Customer>();

            //for(int i=0; i <= 50; i++)
            //{
            //    Customer obj = new Customer();
            //    obj.Email = $"test{i}@gmail.com";
            //    list.Add(obj);
            //}

            //PrintEntities(list);
            //Console.WriteLine();

            //PrintPeople(list);
            //Console.WriteLine();

            //PrintCustomers(list);
            //Console.WriteLine();

            //Customer customer = new Customer();


            Console.ReadLine();
        }

        
        public static void PrintEntities(List<Customer> list)
        {
            foreach(Customer row in list)
            {
                Console.WriteLine($"('{row.EntityId}', '{row.Email}', '{row.CreatedAt}', '{row.ModifiedDate}'),");
            }
        }

        public static void PrintPeople(List<Customer> list)
        {
            foreach (Customer row in list)
            {
                Console.WriteLine($"('{row.PersonId}', '{row.EntityId}', '{row.FirstName}', '{row.LastName}'),");
            }
        }

        public static void PrintCustomers(List<Customer> list)
        {
            foreach (Customer row in list)
            {
                Console.WriteLine($"('{row.CustomerId}', '{row.PersonId}'),");
            }
        }
    }
}
