//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using MetaDomingoLibrary.Models.Derived;
using System;
using System.Collections.Generic;

namespace MetaDomingoLibrary.Models.Base
{
    public abstract class Invoice : LookUp
    {
        // *** Private Fields ***
        private string invoiceId;
        private DateTime invoicedDate;
        private DateTime dueDate;
        private string invoiceRef;
        private bool isPaid;
        private InternalCompany internalCompany;
        private string noteToRecipient;
        private string termsAndConditions;
        private Tax tax;
        private decimal itemsValue;
        private decimal delivery;
        private decimal discount;
        private decimal subTotal;
        private decimal taxAmount;
        private decimal grandTotal;
        private List<InvoiceItem> items;



        //-----------------------------
        // !!! NB: Abstract Class !!!
        //-----------------------------
        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public Invoice() : base()
        {
            invoiceId = "INV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.invoicedDate = DateTime.UtcNow;
            this.dueDate = invoicedDate.AddMonths(1);
            this.isPaid = false;
            this.itemsValue = 0;
            this.delivery = 0;
            this.discount = 0;
            this.subTotal = 0;
            this.taxAmount = 0;
            this.grandTotal = 0;
            this.items = new List<InvoiceItem>();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public Invoice(DateTime invDate, string invRef, bool paid,
                        InternalCompany internalCompany, string note, string terms,
                        decimal itemsValue, decimal delivery, decimal discount,
                        Tax tax, List<InvoiceItem> items)
            : base()
        {
            invoiceId = "INV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.invoicedDate = invDate;
            this.dueDate = invDate.AddMonths(1);
            this.invoiceRef = invRef;
            this.isPaid = paid;
            this.internalCompany = internalCompany;
            this.noteToRecipient = note;
            this.termsAndConditions = terms;
            this.itemsValue = itemsValue;
            this.delivery = delivery;
            this.discount = discount;
            this.tax = tax;
            this.items = items;
        }

        //-Used when initializing objects with values retrieved from database
        public Invoice(string invId, DateTime invDate, DateTime due,
                        string invRef, bool paid, InternalCompany internalCompany,
                        string note, string terms, decimal itemsValue,
                        decimal delivery, decimal discount, Tax tax,
                        List<InvoiceItem> items, DateTime createdAt, DateTime modified)
            : base(createdAt, modified)
        {
            invoiceId = invId;
            this.invoicedDate = invDate;
            this.dueDate = due;
            this.invoiceRef = invRef;
            this.isPaid = paid;
            this.internalCompany = internalCompany;
            this.noteToRecipient = note;
            this.termsAndConditions = terms;
            this.itemsValue = itemsValue;
            this.delivery = delivery;
            this.discount = discount;
            this.tax = tax;
            this.items = items;
        }

        public Invoice(string invId, DateTime invDate, DateTime due,
                        string invRef, bool paid, InternalCompany internalCompany,
                        string note, string terms, decimal itemsValue,
                        decimal delivery, decimal discount, Tax tax,
                        decimal subTot, decimal taxAmt, decimal grandTot,
                        List<InvoiceItem> items, DateTime createdAt, DateTime modified)
            : base(createdAt, modified)
        {
            invoiceId = invId;
            this.invoicedDate = invDate;
            this.dueDate = due;
            this.invoiceRef = invRef;
            this.isPaid = paid;
            this.internalCompany = internalCompany;
            this.noteToRecipient = note;
            this.termsAndConditions = terms;
            this.itemsValue = itemsValue;
            this.delivery = delivery;
            this.discount = discount;
            this.tax = tax;
            this.subTotal = subTot;
            this.taxAmount = taxAmt;
            this.grandTotal = grandTot;
            this.items = items;
        }



        // *** Properties ***
        public string InvoiceId
        {
            get
            {
                return this.invoiceId;
            }
        }

        public DateTime InvoicedDate
        {
            get
            {
                return this.invoicedDate;
            }
            set
            {
                this.invoicedDate = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return InvoicedDate.AddMonths(1);
            }
            set
            {
                this.dueDate = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string InvoiceRef
        {
            get
            {
                return this.invoiceRef;
            }
            set
            {
                this.invoiceRef = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public bool IsPaid
        {
            get
            {
                return this.isPaid;
            }
            set
            {
                this.isPaid = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public InternalCompany InternalCompany
        {
            get
            {
                return this.internalCompany;
            }
            set
            {
                this.internalCompany = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string NoteToRecipient
        {
            get
            {
                return this.noteToRecipient;
            }
            set
            {
                this.noteToRecipient = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string TermsAndConditions
        {
            get
            {
                return this.termsAndConditions;
            }
            set
            {
                this.termsAndConditions = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal Delivery
        {
            get
            {
                return this.delivery;
            }
            set
            {
                this.delivery = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal ItemsValue
        {
            get
            {
                return this.itemsValue;
            }
            set
            {
                this.itemsValue = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return (ItemsValue + Delivery - Discount);
            }
            set
            {
                this.subTotal = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public Tax Tax
        {
            get
            {
                return this.tax;
            }
            set
            {
                this.tax = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal TaxAmount
        {
            get
            {
                return (Subtotal * Tax.TaxPerc);
            }
            set
            {
                this.taxAmount = this.Subtotal * this.Tax.TaxPerc;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal GrandTotal
        {
            get
            {
                return (Subtotal + TaxAmount);
            }
            set
            {
                this.grandTotal = this.Subtotal + this.TaxAmount;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public List<InvoiceItem> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.items = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
