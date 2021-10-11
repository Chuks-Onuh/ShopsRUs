using System;
using System.Linq;
using System.Linq.Expressions;

namespace ShopsRUs.Infrastructure.DataAccess.Interface
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

        void Create(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}


    