using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Application.Interfaces.Mappers;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MyFrameworkList.Application
{
    public class ApplicationServiceLanguage : IApplicationServiceLanguage
    {
        private readonly IServiceLanguage _serviceLanguage;
        private readonly IMapperLanguage _mapperLanguage;

        public ApplicationServiceLanguage(IServiceLanguage serviceLanguage, IMapperLanguage mapperLanguage)
        {
            _serviceLanguage = serviceLanguage;
            _mapperLanguage = mapperLanguage;
        }

        public IEnumerable<LanguageDTO> GetAll()
        {
            try
            {
                var languages = _serviceLanguage.GetAll();

                return _mapperLanguage.MapperListLanguagesDTO(languages);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LanguageDTO GetById(int id)
        {
            try
            {
                var language = _serviceLanguage.GetById(id);

                return _mapperLanguage.MapperLanguagetoLanguageDTO(language);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(LanguageDTO obj)
        {
            try
            {
                var language = _mapperLanguage.MapperLanguageDTOtoLanguage(obj);

                _serviceLanguage.Add(language);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(LanguageDTO obj)
        {
            try
            {
                var language = _mapperLanguage.MapperLanguageDTOtoLanguage(obj);

                _serviceLanguage.Update(language);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            try
            {
                _serviceLanguage.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
