﻿using Domain.App.Interfaces;
using Infrastructure.Data.App.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.App.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private APP_Context _ctx;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(APP_Context ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<TEntity>();
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> Find(Expression<Func<TEntity, bool>> where = null)
        {
            return await _dbSet.Where(where).SingleOrDefaultAsync<TEntity>();

        }

        public virtual async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if(where != null)
            {
                query = query.Where(where);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<bool> IsExists(Expression<Func<TEntity, bool>> where = null)
        {
            return await _dbSet.Where(where).AnyAsync<TEntity>();
        }

        public virtual async Task<TEntity> Remove(Expression<Func<TEntity, bool>> where = null)
        {
            var item = await _dbSet.Where(where).SingleAsync<TEntity>();
            _dbSet.Remove(item);
            await _ctx.SaveChangesAsync();
            return item;
        }

        public virtual async void Save()
        {
            await _ctx.SaveChangesAsync();
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _ctx.SaveChangesAsync();
            return  entity;
        }
    }
}