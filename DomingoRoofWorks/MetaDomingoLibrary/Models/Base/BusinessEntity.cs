//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using System;

namespace MetaDomingoLibrary.Models.Base
{
    public abstract class BusinessEntity : LookUp
    {
        // *** Private Fields ***
        private string entityId;
        private string contactName;
        private string email;
        private string phone;
        private string taxRegistrationNumber;
        private string websiteUrl;
        private string addressLine1;
        private string addressLine2;
        private string cityId;
        private string postCode;
        private string additionalInfo;


        //-----------------------------
        // !!! NB: Abstract Class !!!
        //-----------------------------
        // *** Constructors ***
        //-Used when creating default object
        public BusinessEntity() : base()
        {
            entityId = "ENT" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when initializing default object
        public BusinessEntity(string conName, string email,
                                string phone, string taxNum, string webUrl,
                                string addrLine1, string addrLine2, string cityId,
                                string postCode, string addInfo)
            : base()
        {
            entityId = "ENT" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            contactName = conName;
            this.email = email;
            this.phone = phone;
            taxRegistrationNumber = taxNum;
            websiteUrl = webUrl;
            addressLine1 = addrLine1;
            addressLine2 = addrLine2;
            this.cityId = cityId;
            this.postCode = postCode;
            additionalInfo = addInfo;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public BusinessEntity(string eId, string cName, string email,
                                string phone, string taxNum, string webUrl,
                                string addrLine1, string addrLine2, string cityId,
                                string postCode, string addInfo, DateTime created, DateTime modified) 
            : base(created, modified)
        {
            entityId = eId;
            contactName = cName;
            this.email = email;
            this.phone = phone;
            taxRegistrationNumber = taxNum;
            websiteUrl = webUrl;
            addressLine1 = addrLine1;
            addressLine2 = addrLine2;
            this.cityId = cityId;
            this.postCode = postCode;
            additionalInfo = addInfo;
        }



        // *** Properties ***
        public string EntityId
        {
            get
            {
                return this.entityId;
            }
        }

        public string ContactName
        {
            get
            {
                return this.contactName;
            }
            set
            {
                this.contactName = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string TaxRegistrationNumber
        {
            get
            {
                return this.taxRegistrationNumber;
            }
            set
            {
                this.taxRegistrationNumber = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string WebsiteUrl
        {
            get
            {
                return this.websiteUrl;
            }
            set
            {
                this.websiteUrl = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string AddressLine1
        {
            get
            {
                return this.addressLine1;
            }
            set
            {
                this.addressLine1 = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }
            set
            {
                this.addressLine2 = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string CityId
        {
            get
            {
                return this.cityId;
            }
            set
            {
                this.cityId = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string PostCode
        {
            get
            {
                return this.postCode;
            }
            set
            {
                this.postCode = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }
            set
            {
                this.additionalInfo = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        // *** Methods ***

        public override string ToString()
        {
            return
                "EntityId: " + EntityId + "\n" +
                "ContactName: " + ContactName + "\n" +
                "Email: " + Email + "\n" +
                "Phone: " + Phone + "\n" +
                "TaxRegNumber: " + TaxRegistrationNumber + "\n" +
                "WebsiteURL: " + WebsiteUrl + "\n" +
                "AddressLine1: " + AddressLine1 + "\n" +
                "AddressLine2: " + AddressLine2 + "\n" +
                "CityId: " + CityId + "\n" +
                "PostCode: " + PostCode + "\n" +
                "AdditionalInfo: " + AdditionalInfo + "\n" +
                base.ToString();
        }

    }
}
