//Author: Kenneth Arnesen
//Date Created: 2020/06/30
//Description:
//Last Updated: 2020/06/30

using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.DatabaseModels;
using MetaDomingoLibrary.Models.Derived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDomingoLibrary.Internal.DataAccess
{
    public class CustomerData : ICustomerData
    {
        private readonly ISqlDataAccess _sql;

        public CustomerData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<Customer> GetAllCustomers()
        {
            var data = _sql.LoadData<Customer, dynamic>("dbo.spCustomer_GetAll", new { }, "MetaDomingoDatabase");

            return data;
        }

        public Customer GetCustomerById(string id)
        {
            var data = _sql.LoadData<Customer, dynamic>("dbo.spCustomer_GetById", new { id }, "MetaDomingoDatabase").FirstOrDefault();

            return data;
        }

        public void InsertCustomer(Customer customer)
        {
            //Fix
            _sql.LoadData<Customer, dynamic>("dbo.spCustomer_Insert", 
                new
                {
                    customer.Entity.EntityId,
                    customer.Entity.ContactName,
                    customer.Entity.Phone,
                    customer.Entity.TaxRegistrationNumber,
                    customer.Entity.WebsiteUrl,
                    customer.Entity.AddressLine1,
                    customer.Entity.AddressLine2,
                    customer.Entity.CityId,
                    customer.Entity.PostCode,
                    customer.Entity.AdditionalInfo,
                    customer.Entity.CreatedAt,
                    customer.Entity.ModifiedDate,
                    customer.Person.PersonId,
                    customer.Person.FirstName,
                    customer.Person.LastName,
                    customer.CustomerId,
                },
                "MetaDomingoDatabase");
        }

        public void UpdateCustomer(Customer customer)
        {
            //Fix
            _sql.SaveData<Customer>("dbo.spCustomer_Update", customer, "MetaDomingoDatabase");
        }

        public void DeleteCustomer(string id)
        {
            _sql.LoadData<Customer, dynamic>("dbo.spCustomer_Delete", id, "MetaDomingoDatabase");
        }
    }
}
