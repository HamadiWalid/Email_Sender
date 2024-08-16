using Email_Sender.Models;

namespace Email_Sender.Services
{
    public interface IMailService
    {
        public Task SendMailAsync(MailRequest mailRequest);

    }
}
