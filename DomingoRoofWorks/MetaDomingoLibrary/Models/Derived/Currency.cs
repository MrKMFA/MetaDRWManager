//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Currency : LookUp
    {
        // Private Fields
        private string currencyId;
        private string currencySymbol;
        private string currencyCode;
        private string currencyName;

        // Constructors
        public Currency() : base()
        {
            currencyId = "CNY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        // Properties
        public string CurrencyId
        {
            get
            {
                return this.currencyId;
            }
        }

        public string CurrencySymbol
        {
            get
            {
                return this.currencySymbol;
            }
            set
            {
                this.currencySymbol = value;
            }
        }

        public string CurrencyCode
        {
            get
            {
                return this.currencyCode;
            }
            set
            {
                this.currencyCode = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string CurrencyName
        {
            get
            {
                return this.currencyName;
            }
            set
            {
                this.currencyName = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
