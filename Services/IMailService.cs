using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace TechnicalTassk.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(string toEmail, string subject, string content);
    }
    public class SendGridMailService : IMailService
    {
        private IConfiguration _configuration;

        public SendGridMailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string toEmail, string subject, string content)
        {
            var apiKey = _configuration["SendGridAPIKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("doaa39829@gmail.com", "JWT Auth ");
            var to = new EmailAddress(toEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, content);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
