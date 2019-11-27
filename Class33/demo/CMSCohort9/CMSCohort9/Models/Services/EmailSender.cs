using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSCohort9.Models.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Make connection with Azure SendGrid resource
            SendGridClient client = new SendGridClient(Configuration["SendGridEmail"]);
            SendGridMessage msg = new SendGridMessage();

            // Construct the message
            msg.SetFrom("donotreply@amanda.com", "Blog Admin");
            msg.AddTo(email);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, htmlMessage);

            await client.SendEmailAsync(msg);
            

        }
    }
}
