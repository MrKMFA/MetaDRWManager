using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaDomingoLibrary.Internal.DataAccess;
using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.DatabaseModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetaDomingoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonData _personData;

        public PersonController(IPersonData personData)
        {
            _personData = personData;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personData.GetAllPersons();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
