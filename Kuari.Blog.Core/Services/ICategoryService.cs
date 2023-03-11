using Kuari.Blog.Core.DTOs.Concrete;
using Kuari.Blog.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.Services
{
    public interface ICategoryService : IService<Category,CategoryDto, CategoryUpdateDto>
    {
    }
}
