using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Application.Interfaces.Mappers;
using MyFrameworkList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFrameworkList.Application.Mappers
{
    public class MapperFramework : IMapperFramework
    {
        public Framework MapperFrameworkDTOtoFramework(FrameworkDTO obj)
        {
            try
            {
                return new Framework
                {
                    Id = obj.Id,
                    Name = obj.Name,
                    Description = obj.Description,
                    LanguageId = obj.LanguageId
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FrameworkDTO MapperFrameworktoFrameworkDTO(Framework obj)
        {
            try
            {
                return new FrameworkDTO
                {
                    Id = obj.Id,
                    Name = obj.Name,
                    Description = obj.Description,
                    LanguageId = obj.LanguageId
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<FrameworkDTO> MapperListFrameworksDTO(IEnumerable<Framework> obj)
        {
            try
            {
                return obj.Select(f => new FrameworkDTO
                {
                    Id = f.Id,
                    Name = f.Name,
                    Description = f.Description,
                    LanguageId = f.LanguageId
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
