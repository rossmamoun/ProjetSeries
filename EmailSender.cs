using Microsoft.AspNetCore.Identity.UI.Services;

namespace ProjetSeries
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
        //logic to send mail
        return Task.CompletedTask;
        }
    }
}
