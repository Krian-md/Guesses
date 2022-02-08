using GuessesApi.Database.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Repositories
{
    public class DictionaryRepository : BaseRepository<Dictionary>
    {
        public DictionaryRepository(DataContext db) : base(db)
        {

        }

        public override async Task<Dictionary> Create(Dictionary entity)
        {
            await db.Dictionary.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public override async Task<IEnumerable<Dictionary>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await db.Dictionary.ToListAsync();
        }

        public override async Task<Dictionary> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            return await db.Dictionary.FirstOrDefaultAsync(dict => dict.Id == id);
        }

        public override async void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override async void Update(Dictionary entity)
        {
            throw new NotImplementedException();
        }
    }
}
