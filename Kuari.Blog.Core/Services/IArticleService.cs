using Kuari.Blog.Core.DTOs.Concrete.ArticleDTOs;
using Kuari.Blog.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.Services
{
    public interface IArticleService : IService<Article,ArticleDto,ArticleUpdateDto>
    {
    }
}
