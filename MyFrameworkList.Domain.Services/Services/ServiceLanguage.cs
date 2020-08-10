using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using MyFrameworkList.Domain.Entities;

namespace MyFrameworkList.Domain.Services.Services
{
    public class ServiceLanguage : ServiceBase<Language>, IServiceLanguage
    {
        private readonly IRepositoryLanguage _repositoryLanguage;

        public ServiceLanguage(IRepositoryLanguage repositoryLanguage) : base(repositoryLanguage) => _repositoryLanguage = repositoryLanguage;
    }
}
