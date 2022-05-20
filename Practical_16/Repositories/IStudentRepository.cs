using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Repositories
{
    interface IStudentRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);

        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> IsExist(int id);
    }
}
