//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/23

using System;

namespace MetaDomingoLibrary.Models.Base
{
    public abstract class Person : BusinessEntity
    {
        // *** Private Fields ***
        private string personId;
        private string entityId;
        private BusinessEntity entity;
        private string firstName;
        private string lastName;

        //-----------------------------
        // !!! NB: Abstract Class !!!
        //-----------------------------
        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public Person() : base()
        {
            personId = "PRN" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public Person(string fName, string lName, string conName,
                    string email, string phone, string taxNum,
                    string webUrl, string addrLine1, string addrLine2,
                    string cityId, string postCode, string addInfo)
            : base(conName, email, phone, taxNum, webUrl, addrLine1, addrLine2, cityId, postCode, addInfo)
        {
            personId = "PRN" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            firstName = fName;
            lastName = lName;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public Person(string perId, string lName, string fName, BusinessEntity bEntity)
            : base(bEntity.EntityId, bEntity.ContactName, bEntity.Email, bEntity.Phone, bEntity.TaxRegistrationNumber,
                  bEntity.WebsiteUrl, bEntity.AddressLine1, bEntity.AddressLine2, bEntity.CityId, bEntity.PostCode,
                  bEntity.AdditionalInfo, bEntity.CreatedAt, bEntity.ModifiedDate)
        {
            personId = perId;
            entityId = bEntity.EntityId;
            this.entity = bEntity;
            firstName = fName;
            lastName = lName;
        }



        // *** Properties ***
        public string PersonId
        {
            get
            {
                return this.personId;
            }
        }

        public BusinessEntity Entity
        {
            get
            {
                return this.Entity;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
                this.ModifiedDate = DateTime.UtcNow;
            }
        }

        // *** Methods ***
        public override string ToString()
        {
            return "PersonId: " + PersonId +"\n"+
                    "FirstName: " + FirstName +"\n"+
                    "LastName: " + LastName + "\n"+
                    base.ToString(); 
        }
    }
}
