using Kuari.Blog.Core.UnitOfWork;
using Kuari.Blog.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogDbContext _context;
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
