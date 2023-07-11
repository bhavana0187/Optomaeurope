using ApplicationCore.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Services
{
    public interface IEmailService
    {
        Task<Task> SendContactEmailAsync(string name, string email, string subject, string message, bool isHTMLMessage);
        Task<Task> SendContactEmailAsync(string name,string email, string subject, string message, bool isHTMLMessage, IEnumerable<EmailAttachment> attachments);
        Task<Task> SendContactEmailAsync(string name,string email, string subject, string message, bool isHTMLMessage, IEnumerable<EmailAttachment> attachments, string BCCAddress);        
    }
}
