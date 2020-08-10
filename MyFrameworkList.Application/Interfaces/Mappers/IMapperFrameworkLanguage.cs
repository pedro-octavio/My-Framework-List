using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Domain.Entities;
using System.Collections.Generic;

namespace MyFrameworkList.Application.Interfaces.Mappers
{
    public interface IMapperFrameworkLanguage
    {
        FrameworkLanguageDTO MapperFrameworkLanguagetoFrameworkLanguageDTO(FrameworkLanguage obj);
        IEnumerable<FrameworkLanguageDTO> MapperListFrameworkLanguagesDTO(IEnumerable<FrameworkLanguage> obj);
    }
}
