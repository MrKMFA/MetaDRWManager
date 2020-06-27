using MetaDomingoLibrary.Models.Base;
using System.Collections.Generic;

namespace MetaDomingoLibrary.DataAccess
{
    public interface IUserData
    {
        List<User> GetAllUsers();
    }
}