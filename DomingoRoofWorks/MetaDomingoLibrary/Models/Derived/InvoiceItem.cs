//Author: Kenneth Arnesen
//Date Created: 2020/06/20
//Description:
//Last Updated: 2020/06/20

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class InvoiceItem : LookUp
    {
        // *** Private Fields ***
        private string invoiceItemId;
        private string invoiceId;
        private string itemId;
        private Item item;
        private int quantity;



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        //-Used when instantiating default object (and base class) with initializing property values
        public InvoiceItem(string invId, Item item, int qty) : base()
        {
            invoiceItemId = "IVI" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.invoiceId = invId;
            this.item = item;
            this.quantity = qty;
        }

        //-Used when initializing objects with values retrieved from database
        public InvoiceItem(string invItemId, string invId, string itemId,
                            int qty, DateTime created, DateTime modified,
                            Item item = null)
            : base(created, modified)
        {
            this.invoiceItemId = invItemId;
            this.invoiceId = invId;
            this.itemId = itemId;
            this.item = item;
            this.quantity = qty;
        }



        // *** Properties ***
        public string InvoiceItemId
        {
            get
            {
                return this.InvoiceItemId;
            }
        }

        public string InvoiceId
        {
            get
            {
                return this.invoiceId;
            }
            set
            {
                this.invoiceId = value;
            }
        }

        public string ItemId
        {
            get
            {
                return this.itemId;
            }

            set
            {
                this.itemId = value;
            }
        }

        public Item Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
