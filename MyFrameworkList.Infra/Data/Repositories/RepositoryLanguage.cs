using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Entities;

namespace MyFrameworkList.Infra.Data.Repositories
{
    public class RepositoryLanguage : RepositoryBase<Language>, IRepositoryLanguage
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RepositoryLanguage(ApplicationDbContext applicationDbContext) : base(applicationDbContext) => _applicationDbContext = applicationDbContext;
    }
}
