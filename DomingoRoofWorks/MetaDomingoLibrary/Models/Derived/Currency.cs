//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Currency : LookUp
    {
        // *** Private Fields ***
        private string currencyId;
        private string currencySymbol;
        private string currencyCode;
        private string currencyName;

        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public Currency() : base()
        {
            currencyId = "CNY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public Currency(string curSymbol, string curCode, string curName)
            : base()
        {
            currencySymbol = curSymbol;
            currencyCode = curCode;
            currencyName = curName;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public Currency(string curSymbol, string curCode, string curName,
                        DateTime createdAt, DateTime modified)
            : base(createdAt, modified)
        {
            currencySymbol = curSymbol;
            currencyCode = curCode;
            currencyName = curName;
        }

        // *** Properties ***
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
                base.ModifiedDate = DateTime.UtcNow;
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
