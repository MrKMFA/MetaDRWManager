using MetaDomingoRoofWorks.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MetaDomingoRoofWorks.Services
{
    public interface IDRWService
    {
        Task CreateDefaultSuperAdmin();
        Task<bool> IsAccountActivatedAsync(string email, UserManager<ApplicationUser> userManager);
        Task SendEmailByGmailAsync(string fromEmail, string fromFullName, string subject, string messageBody, string toEmail, string toFullName, string smtpUser, string smtpPassword, string smtpHost, int smtpPort, bool smtpSSL);
        Task SendEmailBySendGridAsync(string apiKey, string fromEmail, string fromFullName, string subject, string message, string email);
        Task UpdateRoles(ApplicationUser appUser, ApplicationUser currentLoginUser);
        Task<string> UploadFile(List<IFormFile> files, IHostingEnvironment env);
    }
}