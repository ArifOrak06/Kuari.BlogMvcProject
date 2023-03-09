using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.Entities.Concrete
{
    public class About
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string DetailsTwo { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlTwo { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
