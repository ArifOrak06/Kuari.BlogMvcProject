using Kuari.Blog.Core.DTOs.Concrete.ArticleDTOs;
using Kuari.Blog.Core.Entities.Concrete;
using Kuari.Blog.Core.Repositories;
using Kuari.Blog.Core.Services;
using Kuari.Blog.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Service.Services
{
    public class ArticleService : Service<Article,ArticleDto,ArticleUpdateDto>, IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ArticleService(IArticleRepository articleRepository, IUnitOfWork unitOfWork) : base(articleRepository,unitOfWork)
        {
            _articleRepository = articleRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
