//Author: Kenneth Arnesen
//Date Created: 2020/06/16
//Description:
//Last Updated: 2020/06/17

using MetaDomingoLibrary.Models.Base;
using System;

namespace MetaDomingoLibrary.Models.Derived
{
    public class City : LookUp
    {
        // Private Fields
        private string cityId;
        private string cityCode;
        private string cityName;

        // Constructors
        public City() : base()
        {
            cityId = "CTY" + DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }

        // Properties
        public string CityId
        {
            get
            {
                return this.cityId;
            }
            set
            {
                this.cityId = value;
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
