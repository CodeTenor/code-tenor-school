using System;
using System.Collections.Generic;

namespace CodeTenorSchool.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T GetById(Guid id);
        IList<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Save();
    }
}
