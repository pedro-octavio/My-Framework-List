using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Application.Interfaces;
using MyFrameworkList.Application.Interfaces.Mappers;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MyFrameworkList.Application
{
    public class ApplicationServiceFramework : IApplicationServiceFramework
    {
        private readonly IServiceFramework _serviceFramework;
        private readonly IMapperFramework _mapperFramework;

        public ApplicationServiceFramework(IServiceFramework serviceFramework, IMapperFramework mapperFramework)
        {
            _serviceFramework = serviceFramework;
            _mapperFramework = mapperFramework;
        }

        public IEnumerable<FrameworkDTO> GetAll()
        {
            try
            {
                var frameworks = _serviceFramework.GetAll();

                return _mapperFramework.MapperListFrameworksDTO(frameworks);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FrameworkDTO GetById(int id)
        {
            try
            {
                var framework = _serviceFramework.GetById(id);

                return _mapperFramework.MapperFrameworktoFrameworkDTO(framework);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(FrameworkDTO obj)
        {
            try
            {
                var framework = _mapperFramework.MapperFrameworkDTOtoFramework(obj);

                _serviceFramework.Add(framework);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(FrameworkDTO obj)
        {
            try
            {
                var framework = _mapperFramework.MapperFrameworkDTOtoFramework(obj);

                _serviceFramework.Update(framework);
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
                _serviceFramework.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
