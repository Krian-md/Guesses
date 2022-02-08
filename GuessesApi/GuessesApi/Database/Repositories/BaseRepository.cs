using GuessesApi.Database.Enteties;
using GuessesApi.Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Repositories
{
    public abstract class BaseRepository<TValue> : IRepository<TValue>
        where TValue : BaseEntity
    {
        protected DataContext db;
        public BaseRepository(DataContext context)
        {
            db = context;
        }
        DbSet<TValue> Table => db.Set<TValue>();

        public abstract Task<TValue> Create(TValue entity);
        public abstract Task<IEnumerable<TValue>> GetAllAsync(CancellationToken cancellationToken = default);
        public abstract Task<TValue> GetAsync(int id, CancellationToken cancellationToken = default);
        public abstract void Remove(int id);
        public abstract void Update(TValue entity);
    }
}
