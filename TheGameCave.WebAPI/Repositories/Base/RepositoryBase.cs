using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TheGameCave.Lib.Models;
using TheGameCave.WebAPI.Data;

namespace TheGameCave.WebAPI.Repositories.Base
{
    public class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        protected readonly TheGameCaveContext _context;

        public RepositoryBase(TheGameCaveContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return null;
            }
            return await Delete(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsNoTracking();
        }

        public async Task<IEnumerable<T>> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return await GetFiltered(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> ListAll()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;

        }
        private async Task<bool> Exists(int id)
        {
            return await _context.Set<T>().AnyAsync(e => e.Id == id);
        }
    }
}
