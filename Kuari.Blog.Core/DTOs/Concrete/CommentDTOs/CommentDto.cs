using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.DTOs.Concrete.CommentDTOs
{
    public class CommentDto
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public int ArticleId { get; set; }
    }
}
