//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/23

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Employee : Person
    {
        // *** Private Fields ***
        private string employeeId;
        private Person person;



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public Employee() : base()
        {
            employeeId = "EMP" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public Employee(string fName, string lName, string conName,
                    string email, string phone, string taxNum,
                    string webUrl, string addrLine1, string addrLine2,
                    string cityId, string postCode, string addInfo)
            : base(fName, lName, conName, email, phone, taxNum, webUrl, addrLine1, addrLine2, cityId, postCode, addInfo)
        {
            employeeId = "EMP" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        public Employee(Person person)
            : base(person.FirstName, person.LastName, person.ContactName, person.Email, person.Phone, person.TaxRegistrationNumber,
                  person.WebsiteUrl, person.AddressLine1, person.AddressLine2, person.CityId, person.PostCode, person.AdditionalInfo)
        {
            employeeId = "EMP" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.person = person;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public Employee(string empId, Person person)
            : base(person.PersonId, person.LastName, person.FirstName, person.Entity)
        {
            this.employeeId = empId;
            this.person = person;
        }



        // Properties
        public string EmployeeId
        {
            get
            {
                return this.employeeId;
            }
        }

        public Person Person
        {
            get
            {
                return this.person;
            }
        }

        public override string ToString()
        {
            string emp = "EmployeeId: " + EmployeeId;

            return $"{String.Format("{0,20}", emp)}\n" +
                    base.ToString();
        }
    }
}
