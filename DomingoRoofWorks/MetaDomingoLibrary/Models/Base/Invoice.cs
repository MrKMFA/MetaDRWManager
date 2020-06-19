//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Derived;
using System;

namespace MetaDomingoLibrary.Models.Base
{
    public abstract class Invoice : LookUp
    {
        // *** Private Fields ***
        private string invoiceId;
        private DateTime dueDate;
        private DateTime invoiceDate;
        private string invoiceRef;
        private bool isPaid;
        private string baseCompanyId;
        private InternalCompany baseCompany;
        private string noteToRecipient;
        private string termsAndConditions;
        private decimal delivery;
        private decimal discount;
        private decimal subTotal;
        private Tax tax;
        private decimal taxAmount;
        private decimal grandTotal;

        // *** Constructors ***
        public Invoice() : base()
        {
            invoiceId = "INV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            dueDate = CreatedAt.AddMonths(1);
            invoiceDate = CreatedAt;
            isPaid = false;
            delivery = 0;
            discount = 0;
            subTotal = 0;
        }

        public Invoice(string invRef, bool paid, InternalCompany baseCompany,
            string note, string terms, decimal delivery,
            decimal discount, decimal subTot, Tax tax) : base()
        {
            invoiceId = "INV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            dueDate = CreatedAt.AddMonths(1);
            invoiceDate = CreatedAt;
            invoiceRef = invRef;
            isPaid = paid;
            this.baseCompany = baseCompany;
            noteToRecipient = note;
            termsAndConditions = terms;
            this.delivery = delivery;
            this.discount = discount;
            subTotal = subTot;
            this.tax = tax;
        }

        // *** Properties ***
        public string InvoiceId
        {
            get
            {
                return this.invoiceId;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return this.dueDate;
            }
            set
            {
                this.dueDate = value;
            }
        }

        public DateTime InvoiceDate
        {
            get
            {
                return this.invoiceDate;
            }
            set
            {
                this.invoiceDate = value;
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
            }
        }

        public string BaseCompanyId
        {
            get
            {
                return this.baseCompany.BaseCompanyId;
            }
        }

        public InternalCompany BaseCompany
        {
            get
            {
                return this.baseCompany;
            }
            set
            {
                this.baseCompany = value;
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
            }
        }

        public decimal Subtotal
        {
            get
            {
                return this.subTotal;
            }
            set
            {
                this.subTotal = value - this.Discount;
            }
        }

        public string TaxId
        {
            get
            {
                return this.Tax.TaxId;
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
            }
        }

        public decimal TaxAmount
        {
            get
            {
                return this.taxAmount;
            }
            set
            {
                this.taxAmount = this.Subtotal * this.Tax.TaxPerc;
            }
        }

        public decimal GrandTotal
        {
            get
            {
                return this.grandTotal;
            }
            set
            {
                this.grandTotal = this.Subtotal + this.TaxAmount;
            }
        }
    }
}
