using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDomingoLibrary.Internal.DataAccess
{
    public class PersonData : IPersonData
    {
        private readonly ISqlDataAccess _sql;

        public PersonData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<Person> GetAllPersons()
        {
            List<Person> listPerson = _sql.LoadData<Person, dynamic>("dbo.spPerson_GetAll", new { },"MetaDomingoDatabase");

            return listPerson;
        }
    }
}
