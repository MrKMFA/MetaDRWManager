//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using System;

namespace MetaDomingoLibrary.Models.Base
{
    public abstract class Person : BusinessEntity
    {
        // *** Private Fields ***
        private string personId;
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

        //-Used when initializing objects with values retrieved from database
        //TODO:



        // *** Properties ***
        public string PersonId
        {
            get
            {
                return this.personId;
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
            }
        }
    }
}
