//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Tax : LookUp
    {
        // Private Fields
        private string taxId;
        private string taxLabel;
        private decimal taxPerc;

        // Constructors
        public Tax() : base()
        {
            taxId = "TAX" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        // Properties
        public string TaxId
        {
            get
            {
                return this.taxId;
            }
        }

        public string TaxLabel
        {
            get
            {
                return this.taxLabel;
            }
            set
            {
                this.taxLabel = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal TaxPerc
        {
            get
            {
                return this.taxPerc;
            }
            set
            {
                this.taxPerc = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
