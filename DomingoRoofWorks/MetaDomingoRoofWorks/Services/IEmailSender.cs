using System.Threading.Tasks;

namespace MetaDomingoRoofWorks.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}