using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Application.Interfaces.Mappers;
using MyFrameworkList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFrameworkList.Application.Mappers
{
    public class MapperLanguage : IMapperLanguage
    {
        public Language MapperLanguageDTOtoLanguage(LanguageDTO obj)
        {
            try
            {
                return new Language
                {
                    Id = obj.Id,
                    Name = obj.Name
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LanguageDTO MapperLanguagetoLanguageDTO(Language obj)
        {
            try
            {
                return new LanguageDTO
                {
                    Id = obj.Id,
                    Name = obj.Name
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<LanguageDTO> MapperListLanguagesDTO(IEnumerable<Language> obj)
        {
            try
            {
                return obj.Select(l => new LanguageDTO
                {
                    Id = l.Id,
                    Name = l.Name
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
