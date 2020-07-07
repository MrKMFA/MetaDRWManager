using MetaDomingoLibrary.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDomingoLibrary.Internal.DataAccess
{
    public class BusinessEntityData : IBusinessEntityData
    {
        private readonly ISqlDataAccess _sql;

        public BusinessEntityData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<BusinessEntity> GetAllBusinessEntities()
        {
            var data = _sql.LoadData<BusinessEntity, dynamic>("dbo.spBusinessEntity_GetAll", new { }, "MetaDomingoDatabase");

            return data;
        }

        public BusinessEntity GetBusinessEntityById(string id)
        {
            var data = _sql.LoadData<BusinessEntity, dynamic>("dbo.spBusinessEntity_GetById", id, "MetaDomingoDatabase").FirstOrDefault();

            return data;
        }
    }
}
