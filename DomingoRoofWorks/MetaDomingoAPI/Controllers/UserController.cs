using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaDomingoAPI.Data;
using MetaDomingoAPI.Models;
using MetaDomingoLibrary.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MetaDomingoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserData _userData;
        private readonly ApplicationDbContext _context;

        public UserController(IUserData userData, ApplicationDbContext context)
        {
            _userData = userData;
            _context = context;
        }

        public List<ApplicationUser> GetAllUsers()
        {
            List<ApplicationUser> output = new List<ApplicationUser>();

            var users = _context.Users.ToList();
            var userRoles = from ur in _context.UserRoles
                            join r in _context.Roles on ur.RoleId equals r.Id
                            select new { ur.UserId, ur.RoleId, r.Name };

            foreach (var user in users)
            {
                ApplicationUser u = new ApplicationUser
                {
                    Id = user.Id,
                    Email = user.Email
                };

                u.Roles = userRoles.Where(x => x.UserId == u.Id).ToDictionary(key => key.RoleId, val => val.Name);

                //foreach (var r in user.Roles)
                //{
                //    u.Roles.Add(r.RoleId, roles.Where(x => x.Id == r.RoleId).First().Name);
                //}

                output.Add(u);
            }

            return output;
        }
    }
}
