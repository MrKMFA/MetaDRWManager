//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/20

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Item : LookUp
    {
        // *** Private Fields ***
        private string itemId;
        private string itemName;
        private string itemDescription;
        private Vendor vendor;
        private bool preferredVendor;
        private decimal costPrice;
        private decimal markupPerc;
        private decimal unitPrice;
        



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        //-Used when instantiating default object (and base class) with initializing property values
        public Item(string name, decimal cost, decimal markup = 1.15M,
            string desc = null, bool preferred = true, Vendor vendor = null)
            : base()
        {
            itemId = "ITM" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.itemName = name;
            this.itemDescription = desc;
            this.vendor = vendor;
            this.preferredVendor = preferred;
            this.costPrice = cost;
            this.markupPerc = markup;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public Item(string itemId, string name, string desc,
                    Vendor vendor, bool preferred, decimal cost,
                    decimal markup, DateTime created, DateTime modified)
            : base(created, modified)
        {
            this.itemId = itemId;
            this.itemName = name;
            this.itemDescription = desc;
            this.vendor = vendor;
            this.preferredVendor = preferred;
            this.costPrice = cost;
            this.markupPerc = markup;
        }

        public Item(string itemId, string name, string desc,
                    Vendor vendor, bool preferred, decimal cost,
                    decimal markup, decimal unitPrice, DateTime created, DateTime modified)
            : base(created, modified)
        {
            this.itemId = itemId;
            this.itemName = name;
            this.itemDescription = desc;
            this.vendor = vendor;
            this.preferredVendor = preferred;
            this.costPrice = cost;
            this.markupPerc = markup;
            this.unitPrice = unitPrice;
        }



        // *** Properties ***
        public string ItemId
        {
            get
            {
                return this.itemId;
            }
        }

        public string ItemName
        {
            get
            {
                return this.itemName;
            }
            set
            {
                this.itemName = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string ItemDescription
        {
            get
            {
                return this.itemDescription;
            }
            set
            {
                this.itemDescription = value;
                base.ModifiedDate = DateTime.UtcNow;
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
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public bool PreferredVendor
        {
            get
            {
                return this.preferredVendor;
            }
            set
            {
                this.preferredVendor = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal CostPrice
        {
            get
            {
                return this.costPrice;
            }
            set
            {
                this.costPrice = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal MarkupPerc
        {
            get
            {
                return this.markupPerc;
            }
            set
            {
                this.markupPerc = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return CostPrice + (CostPrice * MarkupPerc);
            }
            set
            {
                this.unitPrice = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
