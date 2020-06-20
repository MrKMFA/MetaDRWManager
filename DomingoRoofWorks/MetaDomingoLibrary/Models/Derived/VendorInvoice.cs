//Author: Kenneth Arnesen
//Date Created: 2020/06/20
//Description:
//Last Updated: 2020/06/20

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    class VendorInvoice : Invoice
    {
        // *** Private Fields ***
        private string vendorInvoiceId;
        private Vendor vendor;
        private Invoice invoice;



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public VendorInvoice() : base()
        {
            vendorInvoiceId = "VNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public VendorInvoice(Vendor vendor) 
            : base()
        {
            vendorInvoiceId = "VNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.vendor = vendor;
        }

        public VendorInvoice(Vendor vendor, DateTime invDate, string invRef, bool paid,
                        InternalCompany internalCompany, string note, string terms,
                        decimal itemsValue, decimal delivery, decimal discount, Tax tax)
            : base(invDate, invRef, paid, internalCompany, note, terms, itemsValue, delivery, discount, tax)
        {
            vendorInvoiceId = "VNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.vendor = vendor;
        }

        public VendorInvoice(Vendor vendor, Invoice inv)
            : base(inv.InvoicedDate, inv.InvoiceRef, inv.IsPaid, inv.InternalCompany, inv.NoteToRecipient,
                  inv.TermsAndConditions, inv.ItemsValue, inv.Delivery, inv.Discount, inv.Tax)
        {
            vendorInvoiceId = "VNV" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.vendor = vendor;
            this.invoice = inv;
        }

        //-Used when initializing objects with values retrieved from database
        public VendorInvoice(string vendInvId, Vendor vendor, string invId,
                                DateTime invDate, DateTime due, string invRef,
                                bool paid, InternalCompany internalCompany, string note,
                                string terms, decimal itemsValue, decimal delivery,
                                decimal discount, Tax tax, DateTime createdAt,
                                DateTime modified)
            : base(invId, invDate, due, invRef, paid, internalCompany, note, terms, itemsValue, delivery,
                    discount, tax, createdAt, modified)
        {
            vendorInvoiceId = vendInvId;
            this.vendor = vendor;
        }

        public VendorInvoice(string vendInvId, Vendor vendor, Invoice inv)
            : base(inv.InvoiceId, inv.InvoicedDate, inv.DueDate, inv.InvoiceRef, inv.IsPaid, inv.InternalCompany,
                   inv.NoteToRecipient, inv.TermsAndConditions, inv.ItemsValue, inv.Delivery, inv.Discount,
                   inv.Tax, inv.CreatedAt, inv.ModifiedDate)
        {
            vendorInvoiceId = vendInvId;
            this.vendor = vendor;
            this.invoice = inv;
        }


        // *** Properties ***
        public string VendorInvoiceId
        {
            get
            {
                return this.vendorInvoiceId;
            }
        }

        public Vendor Vendor
        {
            get
            {
                return this.vendor;
            }
            set
            {
                this.vendor = value;
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
