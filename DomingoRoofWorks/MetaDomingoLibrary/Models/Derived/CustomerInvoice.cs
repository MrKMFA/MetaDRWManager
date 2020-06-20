//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/20

using MetaDomingoLibrary.Models.Base;
using System;
using System.Collections.Generic;

namespace MetaDomingoLibrary.Models.Derived
{
    public class CustomerInvoice : Invoice
    {
        // *** Private Fields ***
        private string customerInvoiceId;
        private Customer customer;
        private Invoice invoice;



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public CustomerInvoice() : base()
        {
            customerInvoiceId = "CNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public CustomerInvoice(Customer customer)
            : base()
        {
            customerInvoiceId = "CNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.customer = customer;
        }

        public CustomerInvoice(Customer cust, DateTime invDate, string invRef, bool paid,
                        InternalCompany internalCompany, string note, string terms,
                        decimal itemsValue, decimal delivery, decimal discount,
                        Tax tax, List<InvoiceItem> items)
            : base(invDate, invRef, paid, internalCompany, note, terms, itemsValue, delivery, discount, tax, items)
        {
            customerInvoiceId = "CNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.customer = cust;
        }

        public CustomerInvoice(Customer cust, Invoice inv)
            : base(inv.InvoicedDate, inv.InvoiceRef, inv.IsPaid, inv.InternalCompany, inv.NoteToRecipient,
                  inv.TermsAndConditions, inv.ItemsValue, inv.Delivery, inv.Discount, inv.Tax, inv.Items)
        {
            customerInvoiceId = "CNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.customer = cust;
            this.invoice = inv;
        }

        //-Used when initializing objects with values retrieved from database
        public CustomerInvoice(string custInvId, Customer cust, string invId,
                                DateTime invDate, DateTime due, string invRef,
                                bool paid, InternalCompany internalCompany, string note,
                                string terms, decimal itemsValue, decimal delivery,
                                decimal discount, Tax tax, DateTime createdAt,
                                DateTime modified, List<InvoiceItem> items)
            : base(invId, invDate, due, invRef, paid, internalCompany, note, terms, itemsValue, delivery,
                    discount, tax, items, createdAt, modified)
        {
            customerInvoiceId = custInvId;
            this.customer = cust;
        }

        public CustomerInvoice(string custInvId, Customer cust, Invoice inv)
            : base(inv.InvoiceId, inv.InvoicedDate, inv.DueDate, inv.InvoiceRef, inv.IsPaid, inv.InternalCompany,
                   inv.NoteToRecipient, inv.TermsAndConditions, inv.ItemsValue, inv.Delivery, inv.Discount,
                   inv.Tax, inv.Items, inv.CreatedAt, inv.ModifiedDate)
        {
            customerInvoiceId = custInvId;
            this.customer = cust;
            this.invoice = inv;
        }



        // *** Properties ***
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

        public Invoice Invoice
        {
            get
            {
                return this.invoice;
            }
            set
            {
                this.invoice = value;
            }
        }
    }
}
