using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
       Task<T> UpdateAsync(T item);
       Task<bool> DeleteAsync(int id);
       Task<T> CreateAsync(T item);
       Task<T> GetAsync(int id);
       Task<IEnumerable<T>> GetAsync(); 
       Task<bool> ExistAsync(int id);
    }
}