using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        public Task<Task> SendContactEmailAsync(string name, string email, string subject, string message, bool isHTMLMessage)
        {
            throw new NotImplementedException();
        }

        public Task<Task> SendContactEmailAsync(string name, string email, string subject, string message, bool isHTMLMessage, IEnumerable<EmailAttachment> attachments)
        {
            throw new NotImplementedException();
        }

        public Task<Task> SendContactEmailAsync(string name, string email, string subject, string message, bool isHTMLMessage, IEnumerable<EmailAttachment> attachments, string BCCAddress)
        {
            throw new NotImplementedException();
        }
    }
}
