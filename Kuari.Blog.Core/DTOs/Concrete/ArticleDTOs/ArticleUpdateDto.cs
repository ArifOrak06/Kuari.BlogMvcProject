using Kuari.Blog.Core.DTOs.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.DTOs.Concrete
{
    public class ArticleUpdateDto : IUpdateDto
    {
        public string Title { get; set; }
        public string MainContent { get; set; }
        public string ArticleThumbnailImage { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
    }
}
