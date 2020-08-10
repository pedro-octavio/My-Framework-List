using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Application.Interfaces.Mappers;
using MyFrameworkList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFrameworkList.Application.Mappers
{
    public class MapperFrameworkLanguage : IMapperFrameworkLanguage
    {
        public FrameworkLanguageDTO MapperFrameworkLanguagetoFrameworkLanguageDTO(FrameworkLanguage obj)
        {
            try
            {
                return new FrameworkLanguageDTO
                {
                    Id = obj.Id,
                    Name = obj.Name,
                    Description = obj.Description,
                    LanguageId = obj.LanguageId,
                    LanguageDTO = new LanguageDTO
                    {
                        Id = obj.Language.Id,
                        Name = obj.Language.Name
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<FrameworkLanguageDTO> MapperListFrameworkLanguagesDTO(IEnumerable<FrameworkLanguage> obj)
        {
            try
            {
                return obj.Select(fl => new FrameworkLanguageDTO
                {
                    Id = fl.Id,
                    Name = fl.Name,
                    Description = fl.Description,
                    LanguageId = fl.LanguageId,
                    LanguageDTO = new LanguageDTO
                    {
                        Id = fl.Language.Id,
                        Name = fl.Language.Name
                    }
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
