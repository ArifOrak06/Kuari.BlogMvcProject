using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.Entities.Concrete
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainContent { get; set; }
        public string ArticleThumbnailImage { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
