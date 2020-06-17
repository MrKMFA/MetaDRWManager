//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class InternalCompany : BusinessEntity
    {
        // Private Fields
        private string baseCompanyId;
        private string baseCompanyName;

        // Constructors
        public InternalCompany() : base()
        {
            baseCompanyId = "BCY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        // Properties
        public string BaseCompanyId
        {
            get
            {
                return this.baseCompanyId;
            }
            set
            {
                this.baseCompanyId = value;
            }
        }

        public string BaseCompanyName
        {
            get
            {
                return this.baseCompanyName;
            }
            set
            {
                this.baseCompanyName = value;
            }
        }
    }
}
