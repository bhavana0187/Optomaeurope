using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleContact.ViewModels
{
    public class EmailNewViewModel
    {
        [DisplayName("Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Name")]
        [StringLength(128)]
        public string? Name { get; set; }       
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress]
        [StringLength(256)]
        public string? Email { get; set; }        
        [DisplayName("Subject")]
        [Required(ErrorMessage = "Please enter Subject")]
        public string? Subject { get; set; }
        [DisplayName("Message")]
        [Required(ErrorMessage = "Please enter Message")]
        [MaxLength(2048)]
        public string? Message { get; set; }
        [DisplayName("IsHTMlMessage")]
        public bool? IsHTMlMessage { get; set; }
        [DisplayName("Attachments")]
        public IEnumerable<EmailAttachment>? Attachments { get; set; }
        [DisplayName("BCCAddress")]
        public string? BCCAddress { get; set; }
    }

    public class EmailAttachment
    {
        public byte[]? FileBlob { get; set; }
        public string? FileName { get; set; }
        public string? FileContentType { get; set; }
    }
}

