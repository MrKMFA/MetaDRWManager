using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaDomingoRoofWorks.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        //dependency injection
        private SendGridOptions _sendGridOptions { get; }
        private IDRWService _drwService { get; }
        private SmtpOptions _smtpOptions { get; }

        public EmailSender(IOptions<SendGridOptions> sendGridOptions,
            IDRWService drwService,
            IOptions<SmtpOptions> smtpOptions)
        {
            _sendGridOptions = sendGridOptions.Value;
            _drwService = drwService;
            _smtpOptions = smtpOptions.Value;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            //send email using sendgrid via drwService
            _drwService.SendEmailBySendGridAsync(_sendGridOptions.SendGridKey,
                _sendGridOptions.FromEmail,
                _sendGridOptions.FromFullName,
                subject,
                message,
                email).Wait();

            //send email using smtp via dotnetdesk. uncomment to use it
            /*
            _dotnetdesk.SendEmailByGmailAsync(_smtpOptions.fromEmail,
                _smtpOptions.FromFullName,
                subject,
                message,
                email,
                email,
                _smtpOptions.SmtpUserName,
                _smtpOptions.SmtpPassword,
                _smtpOptions.SmtpHost,
                _smtpOptions.SmtpPort,
                _smtpOptions.SmtpSSL).Wait();
                */
            return Task.CompletedTask;
        }
    }
}
