using MetaDomingoRoofWorks.Models;
using System.Threading.Tasks;

namespace MetaDomingoRoofWorks.Services
{
    public interface IRoles
    {
        Task UpdateRoles(ApplicationUser appUser, ApplicationUser currentLoginUser);
    }
}