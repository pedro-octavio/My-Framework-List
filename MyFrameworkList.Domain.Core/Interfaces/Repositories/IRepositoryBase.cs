using System.Collections.Generic;

namespace MyFrameworkList.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Remove(int id);
    }
}
