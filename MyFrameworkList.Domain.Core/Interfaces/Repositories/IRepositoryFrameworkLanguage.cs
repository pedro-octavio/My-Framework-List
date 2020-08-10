using MyFrameworkList.Domain.Entities;
using System.Collections.Generic;

namespace MyFrameworkList.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryFrameworkLanguage
    {
        IEnumerable<FrameworkLanguage> GetAll();
        FrameworkLanguage GetByFrameworkId(int id);
    }
}
