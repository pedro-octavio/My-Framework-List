using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFrameworkList.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RepositoryBase(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _applicationDbContext.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T GetById(int id)
        {
            try
            {
                return _applicationDbContext.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(T obj)
        {
            try
            {
                _applicationDbContext.Set<T>().Add(obj);

                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T obj)
        {
            try
            {
                _applicationDbContext.Set<T>().Update(obj);

                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            try
            {
                _applicationDbContext.Set<T>().Remove(GetById(id));

                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
