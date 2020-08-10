using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFrameworkList.Infra.Data.Repositories
{
    public class RepositoryFrameworkLanguage : IRepositoryFrameworkLanguage
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RepositoryFrameworkLanguage(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;

        public IEnumerable<FrameworkLanguage> GetAll()
        {
            try
            {
                var frameworks = _applicationDbContext.Frameworks.ToList();

                var frameworksLanguagens = new List<FrameworkLanguage>();

                foreach (var framework in frameworks)
                {
                    frameworksLanguagens.Add(new FrameworkLanguage { 
                    Id=framework.Id,
                    Name=framework.Name,
                    Description=framework.Description,
                    LanguageId=framework.LanguageId,
                    Language=_applicationDbContext.Languages.Find(framework.LanguageId)
                    });
                }

                return frameworksLanguagens;
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
                var framework = _applicationDbContext.Frameworks.Find(id);

                return new FrameworkLanguage
                {
                    Id = framework.Id,
                    Name = framework.Name,
                    Description = framework.Description,
                    LanguageId = framework.LanguageId,
                    Language = _applicationDbContext.Languages.Find(framework.LanguageId)
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
