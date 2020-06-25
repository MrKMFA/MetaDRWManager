//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Vendor : BusinessEntity
    {
        // *** Private Fields ***
        private string vendorId;
        private string vendorName;
        private BusinessEntity entity;



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public Vendor() : base()
        {
            vendorId = "VEN" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public Vendor(string vName, string conName, string email,
                      string phone, string taxNum, string webUrl,
                      string addrLine1, string addrLine2, string cityId,
                      string postCode, string addInfo)
            : base(conName, email, phone, taxNum, webUrl, addrLine1, addrLine2, cityId, postCode, addInfo)
        {
            vendorId = "VEN" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            vendorName = vName;
        }

        public Vendor(string vName, BusinessEntity bEntity)
            : base(bEntity.ContactName, bEntity.Email, bEntity.Phone, bEntity.TaxRegistrationNumber, bEntity.WebsiteUrl, 
                  bEntity.AddressLine1, bEntity.AddressLine2, bEntity.CityId, bEntity.PostCode, bEntity.AdditionalInfo)
        {
            vendorId = "VEN" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            vendorName = vName;
            this.entity = bEntity;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public Vendor(string vId, string vName, BusinessEntity bEntity)
            : base(bEntity.ContactName, bEntity.Email, bEntity.Phone, bEntity.TaxRegistrationNumber, bEntity.WebsiteUrl,
                  bEntity.AddressLine1, bEntity.AddressLine2, bEntity.CityId, bEntity.PostCode, bEntity.AdditionalInfo)
        {
            vendorId = vId;
            vendorName = vName;
            this.entity = bEntity;
        }

        // *** Properties ***
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

        public BusinessEntity Entity
        {
            get
            {
                return this.entity;
            }
        }

        public override string ToString()
        {
            string vid = "VendorId: " + VendorId;
            string vme = "VendorName: " + VendorName;

            return $"{String.Format("{0,20}", vid)}\n" +
                   $"{String.Format("{0,20}", vme)}\n" +
                   base.ToString();
        }
    }
}
