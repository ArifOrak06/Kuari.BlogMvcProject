using Kuari.Blog.Core.Repositories;
using Kuari.Blog.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly BlogDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(BlogDbContext context)
        {
            this._context= context;
            this._dbSet = _context.Set<T>();
        }
        public async Task<T> AddASync(T entity)
        {
            var data = await _dbSet.AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _dbSet.AsNoTracking().ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<T>> GetByFilterAsync(Expression<Func<T, bool>> predicate)
        {
            var data = await _dbSet.Where(predicate).ToListAsync();
            return data;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var data = await _dbSet.FindAsync(id);
            return data;
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
