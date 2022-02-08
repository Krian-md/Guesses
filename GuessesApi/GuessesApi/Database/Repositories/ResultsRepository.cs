using GuessesApi.Database.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Repositories
{
    public class ResultsRepository : BaseRepository<Result>
    {
        public ResultsRepository(DataContext db) : base(db)
        {

        }

        public override async Task<Result> Create(Result entity)
        {
            await db.Results.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public override async Task<IEnumerable<Result>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await db.Results.ToListAsync();
        }

        public override async Task<Result> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            return await db.Results.FirstOrDefaultAsync(res => res.Id == id);
        }

        public override async void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override async void Update(Result entity)
        {
            throw new NotImplementedException();
        }
    }
}
