using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Application.Interfaces;
using MyFrameworkList.Application.Interfaces.Mappers;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MyFrameworkList.Application
{
    public class ApplicationServiceFrameworkLanguage : IApplicationServiceFrameworkLanguage
    {
        private readonly IServiceFrameworkLanguage _serviceFrameworkLanguage;
        private readonly IMapperFrameworkLanguage _mapperFrameworkLanguage;

        public ApplicationServiceFrameworkLanguage(IServiceFrameworkLanguage serviceFrameworkLanguage, IMapperFrameworkLanguage mapperFrameworkLanguage)
        {
            _serviceFrameworkLanguage = serviceFrameworkLanguage;
            _mapperFrameworkLanguage = mapperFrameworkLanguage;
        }

        public IEnumerable<FrameworkLanguageDTO> GetAll()
        {
            try
            {
                var frameworksLanguage = _serviceFrameworkLanguage.GetAll();

                return _mapperFrameworkLanguage.MapperListFrameworkLanguagesDTO(frameworksLanguage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FrameworkLanguageDTO GetByFrameworkId(int id)
        {
            try
            {
                var frameworkLanguage = _serviceFrameworkLanguage.GetByFrameworkId(id);

                return _mapperFrameworkLanguage.MapperFrameworkLanguagetoFrameworkLanguageDTO(frameworkLanguage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
