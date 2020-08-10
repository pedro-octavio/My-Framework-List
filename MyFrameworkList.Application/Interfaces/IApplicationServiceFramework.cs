using MyFrameworkList.Application.DTOs;
using System.Collections.Generic;

namespace MyFrameworkList.Application.Interfaces
{
    public interface IApplicationServiceFramework
    {
        IEnumerable<FrameworkDTO> GetAll();
        FrameworkDTO GetById(int id);
        void Add(FrameworkDTO obj);
        void Update(FrameworkDTO obj);
        void Remove(int id);
    }
}
