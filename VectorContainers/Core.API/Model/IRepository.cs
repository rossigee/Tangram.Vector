﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.API.Model
{
    public interface IRepository<TEntity>
    {
        Task<TValue> StoreOrUpdate<TValue>(TValue value, string Id = null);
        IEnumerable<TValue> LoadAll<TValue>();
        Task<bool> Delete(string id);
        Task<TEntity> Load(string id);
        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetFirstOrDefault(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetLast(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetLast();
        Task<IEnumerable<TEntity>> TakeLast(int n);
        Task<IEnumerable<TEntity>> GetRange(int skip, int take);
    }
}