﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TheGameCave.WebAPI.Models;

namespace TheGameCave.WebAPI.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> GetById(int id);
        IQueryable<T> GetAll();
        Task<IEnumerable<T>> ListAll();
        Task<T> Add(T entity);
        Task<T> Delete(T entity);
        Task<T> Delete(int id);
        Task<T> Update(T entity);
        IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetFilteredList(Expression<Func<T, bool>> predicate);
    }
}
