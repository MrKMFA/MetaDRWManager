using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDomingoLibrary.Models.Base
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
