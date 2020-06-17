//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Customer : Person
    {
        // Private Fields
        private string customerId;

        // Constructors
        public Customer() : base()
        {
            customerId = "CUS" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        // Properties
        public string CustomerId
        {
            get
            {
                return this.customerId;
            }
        }
    }
}
