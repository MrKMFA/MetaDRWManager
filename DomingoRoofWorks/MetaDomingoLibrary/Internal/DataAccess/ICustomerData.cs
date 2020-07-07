//Author: Kenneth Arnesen
//Date Created: 2020/06/30
//Description:
//Last Updated: 2020/06/30

using MetaDomingoLibrary.Models.DatabaseModels;
using MetaDomingoLibrary.Models.Derived;
using System.Collections.Generic;

namespace MetaDomingoLibrary.Internal.DataAccess
{
    public interface ICustomerData
    {
        void DeleteCustomer(string id);
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(string id);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
}