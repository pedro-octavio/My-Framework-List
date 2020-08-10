using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MyFrameworkList.Domain.Services.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase) => _repositoryBase = repositoryBase;

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _repositoryBase.GetAll();
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
                return _repositoryBase.GetById(id);
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
                _repositoryBase.Add(obj);
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
                _repositoryBase.Update(obj);
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
                _repositoryBase.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
