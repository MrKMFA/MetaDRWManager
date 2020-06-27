using MetaDomingoLibrary.Internal.DataAccess;
using MetaDomingoLibrary.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDomingoLibrary.DataAccess
{
    public class UserData : IUserData
    {
        private readonly SqlDataAccess _sql;

        public UserData(SqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<User> GetAllUsers()
        {
            var data = _sql.LoadData<User, dynamic>("dbo.spUser_GetAll", new { }, "MetaDomingoDatabase");

            return data;
        }
    }
}
