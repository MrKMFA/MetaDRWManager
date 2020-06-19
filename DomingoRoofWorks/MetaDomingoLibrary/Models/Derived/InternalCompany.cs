//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class InternalCompany : BusinessEntity
    {
        // *** Private Fields ***
        private string internalCompanyId;
        private string internalCompanyName;

        // *** Constructors ***

        //Used when creating new object
        public InternalCompany() : base()
        {
            internalCompanyId = "BCY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //Used when initializing objects with values retrieved from database
        //TODO: Create constructor

        // *** Properties ***
        public string InternalCompanyId
        {
            get
            {
                return this.internalCompanyId;
            }
            set
            {
                this.internalCompanyId = value;
            }
        }

        public string InternalCompanyName
        {
            get
            {
                return this.internalCompanyName;
            }
            set
            {
                this.internalCompanyName = value;
            }
        }
    }
}
