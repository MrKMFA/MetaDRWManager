//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class CustomerInvoice : Invoice
    {
        // Private Fields
        private string customerInvoiceId;
        private Customer customer;

        // Constructors
        public CustomerInvoice() : base()
        {
            customerInvoiceId = "CNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        public CustomerInvoice(Customer customer,
            string invRef, bool paid, InternalCompany baseCompany,
            string note, string terms, decimal delivery,
            decimal discount, decimal subTot, Tax tax)
            : base(invRef, paid, baseCompany, note, terms, delivery, discount, subTot, tax)
        {
            customerInvoiceId = "CNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.customer = customer;
        }

        // Properties
        public string CustomerInvoiceId
        {
            get
            {
                return this.customerInvoiceId;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public string CustomerId
        {
            get
            {
                return this.Customer.CustomerId;
            }
        }
    }
}
