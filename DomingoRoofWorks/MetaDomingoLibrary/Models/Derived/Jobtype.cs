//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Jobtype : LookUp
    {
        // Private Fields
        private string jobtypeId;
        private string jobtypeDescription;
        private string jobtypeName;
        private string currencyId;
        private decimal rate;
        private string taxId;

        // Constructors
        public Jobtype() : base()
        {
            jobtypeId = "JTE" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        public Jobtype(string currencyId, string taxId, decimal rate) : base()
        {
            jobtypeId = "JTE" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            this.currencyId = currencyId;
            this.taxId = taxId;
            this.rate = rate;
        }

        // Properties
        public string JobtypeId
        {
            get
            {
                return this.jobtypeId;
            }
        }

        public string JobtypeDescription
        {
            get
            {
                return this.jobtypeDescription;
            }
            set
            {
                this.jobtypeDescription = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string JobtypeName
        {
            get
            {
                return this.jobtypeName;
            }
            set
            {
                this.jobtypeName = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string CurrencyId
        {
            get
            {
                return this.currencyId;
            }
            set
            {
                this.currencyId = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal Rate
        {
            get
            {
                return this.rate;
            }
            set
            {
                this.rate = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string TaxId
        {
            get
            {
                return this.taxId;
            }
            set
            {
                this.taxId = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
