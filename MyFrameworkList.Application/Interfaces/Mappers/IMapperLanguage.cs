using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Domain.Entities;
using System.Collections.Generic;

namespace MyFrameworkList.Application.Interfaces.Mappers
{
    public interface IMapperLanguage
    {
        Language MapperLanguageDTOtoLanguage(LanguageDTO obj);
        LanguageDTO MapperLanguagetoLanguageDTO(Language obj);
        IEnumerable<LanguageDTO> MapperListLanguagesDTO(IEnumerable<Language> obj);
    }
}
