using MyFrameworkList.Application.DTOs;
using System.Collections.Generic;

namespace MyFrameworkList.Application.Interfaces
{
    public interface IApplicationServiceFrameworkLanguage
    {
        IEnumerable<FrameworkLanguageDTO> GetAll();
        FrameworkLanguageDTO GetByFrameworkId(int id);
    }
}
