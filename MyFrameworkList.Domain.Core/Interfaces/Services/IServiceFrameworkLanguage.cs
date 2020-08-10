using MyFrameworkList.Domain.Entities;
using System.Collections.Generic;

namespace MyFrameworkList.Domain.Core.Interfaces.Services
{
    public interface IServiceFrameworkLanguage
    {
        IEnumerable<FrameworkLanguage> GetAll();
        FrameworkLanguage GetByFrameworkId(int id);
    }
}
