using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.DTOs.Concrete.ContactDTOs
{
    public class ContactDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime ContactDate { get; set; }
        public bool Status { get; set; }
    }
}
