using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaDomingoLibrary.Internal.DataAccess;
using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.DatabaseModels;
using MetaDomingoLibrary.Models.Derived;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetaDomingoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerData _customerData;
        private readonly IBusinessEntityData _businessEntityData;

        public CustomerController(ICustomerData customerData, IBusinessEntityData businessEntityData)
        {
            _customerData = customerData;
            _businessEntityData = businessEntityData;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var data = _customerData.GetAllCustomers();
            //var data = _businessEntityData.GetAllBusinessEntities();

            return data;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
