using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Entities;

namespace MyFrameworkList.Infra.Data.Repositories
{
    public class RepositoryFramework : RepositoryBase<Framework>, IRepositoryFramework
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RepositoryFramework(ApplicationDbContext applicationDbContext) : base(applicationDbContext) => _applicationDbContext = applicationDbContext;
    }
}
