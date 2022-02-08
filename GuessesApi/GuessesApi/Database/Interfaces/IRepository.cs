using GuessesApi.Database.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Interfaces
{
    public interface IRepository<TValue>
       where TValue : BaseEntity
    {
        Task<IEnumerable<TValue>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TValue> GetAsync(int id, CancellationToken cancellationToken = default);
        Task<TValue> Create(TValue entity);
        void Remove(int id);
        void Update(TValue entity);
    }
}
