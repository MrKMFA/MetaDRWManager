using MetaDomingoLibrary.Models.Base;
using MetaDomingoLibrary.Models.DatabaseModels;
using System.Collections.Generic;

namespace MetaDomingoLibrary.Internal.DataAccess
{
    public interface IPersonData
    {
        List<Person> GetAllPersons();
    }
}