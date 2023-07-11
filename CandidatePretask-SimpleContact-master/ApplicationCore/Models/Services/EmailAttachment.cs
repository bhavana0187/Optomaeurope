using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Services
{
    public class EmailAttachment
    {
        public byte[]? FileBlob { get; set; }
        public string? FileName { get; set; }
        public string? FileContentType { get; set; }
    }
}
