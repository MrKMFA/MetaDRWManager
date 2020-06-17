//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using System;

namespace MetaDomingoLibrary.Models.Base
{
    public abstract class Person : BusinessEntity
    {
        // *** Private Fields ***
        private string personId;
        private string firstName;
        private string lastName;

        // *** Constructors ***
        public Person() : base()
        {
            personId = "PRN" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

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
