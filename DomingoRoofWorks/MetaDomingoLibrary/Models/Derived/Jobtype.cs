//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class Jobtype : LookUp
    {
        // *** Private Fields ***
        private string jobtypeId;
        private string jobtypeName;
        private string jobtypeDescription;
        private decimal rate;



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public Jobtype() : base()
        {
            jobtypeId = "JTE" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public Jobtype(string jName, string jDesc, decimal rate)
            : base()
        {
            jobtypeId = "JTE" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();

            jobtypeName = jName;
            jobtypeDescription = jDesc;
            this.rate = rate;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public Jobtype(string jId, string jName, string jDesc,
                        decimal rate, DateTime createdAt, DateTime modified)
            : base(createdAt, modified)
        {
            jobtypeId = jId;
            jobtypeName = jName;
            jobtypeDescription = jDesc;
            this.rate = rate;
        }



        // *** Properties ***
        public string JobtypeId
        {
            get
            {
                return this.jobtypeId;
            }
        }

        public string JobtypeName
        {
            get
            {
                return this.jobtypeName;
            }
            set
            {
                this.jobtypeName = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string JobtypeDescription
        {
            get
            {
                return this.jobtypeDescription;
            }
            set
            {
                this.jobtypeDescription = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public decimal Rate
        {
            get
            {
                return this.rate;
            }
            set
            {
                this.rate = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
