//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Item : LookUp
    {
        // Private Fields
        private string itemId;
        private string itemName;
        private string itemDescription;
        private string vendorId;
        private Vendor vendor;
        private bool preferredVendor;
        private decimal costPrice;
        private decimal unitPrice;
        private decimal markupPerc;

        // Constructors
        public Item(string name, string vendorId, decimal cost, decimal markup = 1.15M,
            string desc = null, bool preferred = true, Vendor vendor = null)
            : base()
        {
            itemId = "ITM" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.itemName = name;
            this.vendorId = vendorId;
            this.itemDescription = desc;
            this.vendor = vendor;
            this.preferredVendor = preferred;
            this.costPrice = cost;
            this.markupPerc = markup;
            this.unitPrice = this.costPrice * this.markupPerc;
        }

        // Properties
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
            }
        }

        public string VendorId
        {
            get
            {
                return this.vendor.VendorId;
            }
            set
            {
                this.vendorId = value;
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

        public bool PreferredVendor
        {
            get
            {
                return this.preferredVendor;
            }
            set
            {
                this.preferredVendor = value;
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
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                this.unitPrice = CostPrice * MarkupPerc;
            }
        }
    }
}
