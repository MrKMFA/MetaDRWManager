//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/20

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class InternalCompany : BusinessEntity
    {
        // *** Private Fields ***
        private string internalCompanyId;
        private string internalCompanyName;
        private BusinessEntity entity;


        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public InternalCompany() : base()
        {
            internalCompanyId = "ICY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public InternalCompany(string intCompName, string conName, string email,
                      string phone, string taxNum, string webUrl,
                      string addrLine1, string addrLine2, string cityId,
                      string postCode, string addInfo)
            : base(conName, email, phone, taxNum, webUrl, addrLine1, addrLine2, cityId, postCode, addInfo)
        {
            this.internalCompanyId = "ICY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.internalCompanyName = intCompName;
        }

        public InternalCompany(string intCompName, BusinessEntity bEntity)
            : base(bEntity.ContactName, bEntity.Email, bEntity.Phone, bEntity.TaxRegistrationNumber, bEntity.WebsiteUrl,
                  bEntity.AddressLine1, bEntity.AddressLine2, bEntity.CityId, bEntity.PostCode, bEntity.AdditionalInfo)
        {
            this.internalCompanyId = "ICY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.internalCompanyName = intCompName;
            this.entity = bEntity;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public InternalCompany(string intCompId, string intCompName, BusinessEntity bEntity)
            : base(bEntity.ContactName, bEntity.Email, bEntity.Phone, bEntity.TaxRegistrationNumber, bEntity.WebsiteUrl,
                  bEntity.AddressLine1, bEntity.AddressLine2, bEntity.CityId, bEntity.PostCode, bEntity.AdditionalInfo)
        {
            this.internalCompanyId = intCompId;
            this.InternalCompanyName = intCompName;
            this.entity = bEntity;
        }

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

        public BusinessEntity Entity
        {
            get
            {
                return this.entity;
            }
        }
    }
}
