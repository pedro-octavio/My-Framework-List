using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using MyFrameworkList.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MyFrameworkList.Domain.Services.Services
{
    public class ServiceFrameworkLanguage : IServiceFrameworkLanguage
    {
        private readonly IRepositoryFrameworkLanguage _repositoryFrameworkLanguage;

        public ServiceFrameworkLanguage(IRepositoryFrameworkLanguage repositoryFrameworkLanguage) => _repositoryFrameworkLanguage = repositoryFrameworkLanguage;

        public IEnumerable<FrameworkLanguage> GetAll()
        {
            try
            {
                return _repositoryFrameworkLanguage.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FrameworkLanguage GetByFrameworkId(int id)
        {
            try
            {
                return _repositoryFrameworkLanguage.GetByFrameworkId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
