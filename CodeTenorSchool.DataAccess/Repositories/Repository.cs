using CodeTenorSchool.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTenorSchool.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : DomainEntity
    {
        private readonly CodeTenorSchoolDBContext context = null;

        public Repository(CodeTenorSchoolDBContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }

        public void Add(T entity)
        {
            try
            {
                context.Set<T>().Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            try
            {
                return context.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Save()
        {
            context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
