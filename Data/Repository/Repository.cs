using Core.Repository;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly AdventureWorksContext _context;
        private readonly DbSet<T> _model;

        public Repository(AdventureWorksContext context)
        {
            _context = context;
            _model = _context.Set<T>();
        }

        public async Task<T> InsertAsync(T model)
        {
            _model.Add(model);
            await SaveAsync();
            return model;
        }

        public async Task<bool> EditAsync(T model)
        {
            bool status = false;
            _context.Entry(model).State = EntityState.Modified;
            if (await SaveAsync())
            {
                status = true;
            }
            return status;
        }

        public async Task<bool> DeleteAsync(T model)
        {
            bool status = false;
            _context.Entry(model).State = EntityState.Deleted;
            if (await SaveAsync())
            {
                status = true;
            }
            return status;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> where)
        {
            bool status = false;
            T model = _model.Where(where).FirstOrDefault();
            if (model != null)
            {
                status = await DeleteAsync(model);
            }
            return status;
        }

        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> where)
        {
            return await _model.Where(where).ToListAsync();
        }

        public async Task<List<T>> FindAllAsync()
        {
            return await _model.ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> where)
        {
            return await _model.Where(where).FirstOrDefaultAsync();
        }

        public IQueryable<T> Query()
        {
            return _model;
        }

        public IQueryable<T> Query(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> Set = Query();
            foreach (var include in includes)
            {
                Set = Set.Include(include);
            }
            return Set;
        }

        public IQueryable<T> QueryFast()
        {
            return _model.AsNoTracking();
        }

        public IQueryable<T> QueryFast(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> Set = QueryFast();
            foreach (var include in includes)
            {
                Set = Set.Include(include);
            }
            return Set.AsNoTracking();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}