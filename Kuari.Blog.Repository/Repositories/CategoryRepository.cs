using Kuari.Blog.Core.Entities.Concrete;
using Kuari.Blog.Core.Repositories;
using Kuari.Blog.Repository.Contexts;

namespace Kuari.Blog.Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly BlogDbContext _context;
        public CategoryRepository(BlogDbContext context) : base(context) 
        {
            _context = context; 
        }


    }
}
