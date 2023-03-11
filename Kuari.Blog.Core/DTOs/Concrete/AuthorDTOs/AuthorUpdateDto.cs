using Kuari.Blog.Core.DTOs.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.DTOs.Concrete
{
    public class AuthorUpdateDto : IUpdateDto
    {
        public string Name { get; set; }
        public string About { get; set; }
        public string ProfilImage { get; set; }
        public bool Status { get; set; }
    }
}
