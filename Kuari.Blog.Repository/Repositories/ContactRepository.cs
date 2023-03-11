using Kuari.Blog.Core.Entities.Concrete;
using Kuari.Blog.Core.Repositories;
using Kuari.Blog.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Repository.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        private readonly BlogDbContext _context;
        public ContactRepository(BlogDbContext context) : base(context)
        {
            this._context= context;
        }
    }
}
