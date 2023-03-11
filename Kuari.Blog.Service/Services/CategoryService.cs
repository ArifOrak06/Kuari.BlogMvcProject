using Kuari.Blog.Core.DTOs.Concrete.CategoryDTOs;
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
    public class CategoryService : Service<Category,CategoryDto,CategoryUpdateDto>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : base(categoryRepository,unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
