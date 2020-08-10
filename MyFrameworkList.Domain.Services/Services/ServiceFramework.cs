using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using MyFrameworkList.Domain.Entities;

namespace MyFrameworkList.Domain.Services.Services
{
    public class ServiceFramework : ServiceBase<Framework>, IServiceFramework
    {
        private readonly IRepositoryFramework _repositoryFramework;

        public ServiceFramework(IRepositoryFramework repositoryFramework) : base(repositoryFramework) => _repositoryFramework = repositoryFramework;
    }
}
