using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDomingoRoofWorks.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [EmailAddress]
        public string Email { get; set; }
    }
}
