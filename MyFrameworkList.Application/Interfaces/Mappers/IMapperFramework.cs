using MyFrameworkList.Application.DTOs;
using MyFrameworkList.Domain.Entities;
using System.Collections.Generic;

namespace MyFrameworkList.Application.Interfaces.Mappers
{
    public interface IMapperFramework
    {
        Framework MapperFrameworkDTOtoFramework(FrameworkDTO obj);
        FrameworkDTO MapperFrameworktoFrameworkDTO(Framework obj);
        IEnumerable<FrameworkDTO> MapperListFrameworksDTO(IEnumerable<Framework> obj);
    }
}
