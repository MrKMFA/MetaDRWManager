using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaDomingoLibrary.Internal.DataAccess;
using MetaDomingoLibrary.Models.Base;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetaDomingoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessEntityController : ControllerBase
    {
        private readonly IBusinessEntityData _businessEntityData;

        public BusinessEntityController(IBusinessEntityData businessEntityData)
        {
            _businessEntityData = businessEntityData;
        }

        // GET: api/<BusinessEntityController>
        [HttpGet]
        public IEnumerable<BusinessEntity> Get()
        {
            return _businessEntityData.GetAllBusinessEntities();
        }

        // GET api/<BusinessEntityController>/5
        [HttpGet("{id}")]
        public BusinessEntity Get(string id)
        {
            return _businessEntityData.GetBusinessEntityById(id);
        }

        // POST api/<BusinessEntityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BusinessEntityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BusinessEntityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
