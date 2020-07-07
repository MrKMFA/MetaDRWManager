//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using System;

namespace MetaDomingoLibrary.Models.Base
{
    public class BusinessEntity : LookUp
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
            set
            {
                this.entityId = value;
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
            string ent = "EntityId: " + EntityId;
            string cname = "ContactName: " + ContactName;
            string email = "Email: " + Email;
            string phne = "Phone: " + Phone;
            string txregnum = "TaxRegNumber: " + TaxRegistrationNumber;
            string web = "WebsiteURL: " + WebsiteUrl;
            string ad1 = "AddressLine1: " + AddressLine1;
            string ad2 = "AddressLine2: " + AddressLine2;
            string cty = "CityId: " + CityId;
            string pcde = "PostCode: " + PostCode;
            string adinfo = "AdditionalInfo: " + AdditionalInfo;

            return
                $"{String.Format("{0,20}", ent)}\n" +
                $"{String.Format("{0,20}", cname)}\n" +
                $"{String.Format("{0,20}", email)}\n" +
                $"{String.Format("{0,20}", phne)}\n" +
                $"{String.Format("{0,20}", txregnum)}\n" +
                $"{String.Format("{0,20}", web)}\n" +
                $"{String.Format("{0,20}", ad1)}\n" +
                $"{String.Format("{0,20}", ad2)}\n" +
                $"{String.Format("{0,20}", cty)}\n" +
                $"{String.Format("{0,20}", pcde)}\n" +
                $"{String.Format("{0,20}", adinfo)}\n" +
                base.ToString();
        }

    }
}
