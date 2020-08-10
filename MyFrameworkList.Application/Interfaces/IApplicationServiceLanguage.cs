using MyFrameworkList.Application.DTOs;
using System.Collections.Generic;

namespace MyFrameworkList.Application
{
    public interface IApplicationServiceLanguage
    {
        IEnumerable<LanguageDTO> GetAll();
        LanguageDTO GetById(int id);
        void Add(LanguageDTO obj);
        void Update(LanguageDTO obj);
        void Remove(int id);
    }
}
