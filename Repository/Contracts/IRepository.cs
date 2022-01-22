using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IRepository<T>
        where T: class
    {
        public Task<T> GetAsync(Guid id);

        public Task<IEnumerable<T>> GetAllAsync();

        public Task Create(T item);

        public Task Delete(Guid id);
    }
}
