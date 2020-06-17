//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Vendor : BusinessEntity
    {
        // Private Fields
        private string vendorId;
        private string vendorName;

        // Constructors
        public Vendor() : base()
        {
            vendorId = "VEN" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        // Properties
        public string VendorId
        {
            get
            {
                return this.vendorId;
            }
        }

        public string VendorName
        {
            get
            {
                return this.vendorName;
            }
            set
            {
                this.vendorName = value;
            }
        }
    }
}
