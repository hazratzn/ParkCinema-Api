﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.EFRepository
{
    public class EFRepositoryBase<TEntity, IContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where IContext : DbContext, new()

    {
        protected readonly IContext Context;
        public EFRepositoryBase(IContext context)
        {
            Context = context;
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? await Context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync()
                : await Context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter);
        }
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return await Context.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            return await Context.Set<TEntity>().AsNoTracking().Where(filter).ToListAsync();
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            await using var db_contextTransaction = await Context.Database.BeginTransactionAsync();
            try
            {
                await Context.Set<TEntity>().AddAsync(entity);
                await Context.SaveChangesAsync();
                await db_contextTransaction.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                await db_contextTransaction.RollbackAsync();
                throw;
            }
        }
        public async Task<object> AddReturnEntityAsync(TEntity entity)
        {
            await using var db_contextTransaction = await Context.Database.BeginTransactionAsync();
            try
            {
                var returnEntity = await Context.Set<TEntity>().AddAsync(entity);
                await Context.SaveChangesAsync();
                await db_contextTransaction.CommitAsync();
                return returnEntity;
            }
            catch (Exception)
            {
                await db_contextTransaction.RollbackAsync();
                throw;
            }
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            await using var db_contextTransaction = await Context.Database.BeginTransactionAsync();
            try
            {
                Context.Set<TEntity>().Remove(entity);
                await Context.SaveChangesAsync();
                await db_contextTransaction.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                await db_contextTransaction.RollbackAsync();
                throw;
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            await using var db_contextTransaction = await Context.Database.BeginTransactionAsync();
            try
            {
                Context.Set<TEntity>().Update(entity);
                await Context.SaveChangesAsync();
                await db_contextTransaction.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                await db_contextTransaction.RollbackAsync();
                throw;
            }
        }
        public async Task<bool> UpdateWithEntryAsync(TEntity entity, params object[] propertyNames)
        {
            await using var db_contextTransaction = await Context.Database.BeginTransactionAsync();
            try
            {
                Context.Entry(entity).State = EntityState.Modified;
                for (int i = 0; i < propertyNames.Count(); i++)
                {
                    Context.Entry(entity).Property(propertyNames[i].ToString()).IsModified = false;

                    foreach (var p in Context.Entry(propertyNames[i].ToString()).Properties.Where(p => p.Metadata.Name != "Label"))
                        p.IsModified = false;
                }
                await Context.SaveChangesAsync();
                await db_contextTransaction.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                await db_contextTransaction.RollbackAsync();
                throw;
            }
        }
    }
}
