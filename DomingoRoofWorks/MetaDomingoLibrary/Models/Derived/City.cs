//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/19

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class City : LookUp
    {
        // *** Private Fields ***
        private string cityId;
        private string cityCode;
        private string cityName;



        // *** Constructors ***
        //-Used when instantiating default object and included base class
        public City() : base()
        {
            cityId = "CTY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        //-Used when instantiating default object (and base class) with initializing property values
        public City(string cCode, string cName)
            : base()
        {
            cityId = "CTY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            this.cityCode = cCode;
            this.cityName = cName;
        }

        //-Used when instantiating objects and initializing with values retrieved from database
        public City(string cId, string cCode, string cName,
                    DateTime createdAt, DateTime modified)
            : base(createdAt, modified)
        {
            this.cityId = cId;
            this.cityCode = cCode;
            this.cityName = cName;
        }



        // *** Properties ***
        public string CityId
        {
            get
            {
                return this.cityId;
            }
        }

        public string CityCode
        {
            get
            {
                return this.cityCode;
            }
            set
            {
                this.cityCode = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }

        public string CityName
        {
            get
            {
                return this.cityName;
            }
            set
            {
                this.cityName = value;
                base.ModifiedDate = DateTime.UtcNow;
            }
        }
    }
}
