using MetaDomingoLibrary.Models.Base;
using System.Collections.Generic;

namespace MetaDomingoLibrary.Internal.DataAccess
{
    public interface IBusinessEntityData
    {
        List<BusinessEntity> GetAllBusinessEntities();

        BusinessEntity GetBusinessEntityById(string id);
    }
}