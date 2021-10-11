using Microsoft.EntityFrameworkCore;
using ShopsRUs.Infrastructure.DataAccess.Interface;
using ShopsRUs.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ShopsRUs.Infrastructure.DataAccess.Repository
{
    public class GenericRepository<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext _dbContext;

        public GenericRepository(AppDbContext context) =>
            _dbContext = context;


        public void Create(T Entity) => _dbContext.Set<T>().Add(Entity);
        public void Delete(T Entity) => _dbContext.Set<T>().Remove(Entity);

        public IQueryable<T> FindAll(bool trackChanges) => !trackChanges ?
            _dbContext.Set<T>()
            .AsNoTracking() : _dbContext.Set<T>();


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        => !trackChanges ? _dbContext.Set<T>()
            .Where(expression)
            .AsNoTracking() : _dbContext.Set<T>()
            .Where(expression);

        public void Update(T Entity) => _dbContext.Set<T>().Update(Entity);
    }
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }
        public static PagedList<T> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
