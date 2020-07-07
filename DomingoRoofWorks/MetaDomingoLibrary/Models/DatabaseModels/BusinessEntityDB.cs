using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDomingoLibrary.Models.DatabaseModels
{
    public class BusinessEntityDB
    {
        public string EntityId { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityId { get; set; }
        public string PostCode { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
