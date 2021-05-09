﻿using CodeSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSample.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ExampleDBContext _dbContext;
        private DbSet<TEntity> _dbSet;
        public Repository(ExampleDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
        public async Task<int> Add(TEntity entity)
        {
            int output = 0;
            _dbSet.Add(entity);
            output=await _dbContext.SaveChangesAsync();
            return output;
        }
        public int Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public TEntity Get(long id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TEntity> GetAll()
        {           
            return _dbSet.ToList();
        }
        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
