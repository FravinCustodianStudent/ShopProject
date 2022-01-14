using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Fravin.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject,htmlMessage);
        }
        public async Task Execute(string email, string subject, string body)
        {
            MailjetClient client = new MailjetClient("4af3fe7066f4df8fa433a73467365ab1","2adf7eed802785123909dbe610771c42")
            {
                Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
     new JObject {
      {
       "From",
       new JObject {
        {"Email", "fravincustodian@protonmail.com"},
        {"Name", "Fravin"}
       }
      }, {
       "To",
       new JArray {
        new JObject {
         {
          "Email",
          email
         }, {
          "Name",
          "Fravin"
         }
        }
       }
      }, {
       "Subject",
       subject
      }, {
       "HTMLPart",
       body
      }
     }
             });
            await client.PostAsync(request);
        }
    }
}
