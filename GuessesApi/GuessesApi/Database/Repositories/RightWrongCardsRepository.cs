using GuessesApi.Database.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Repositories
{
    public class RightWrongCardsRepository : BaseRepository<RightWrongCard>
    {
        public RightWrongCardsRepository(DataContext db) : base(db)
        {

        }

        public override async Task<RightWrongCard> Create(RightWrongCard entity)
        {
            await db.RightWrongCards.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public override async Task<IEnumerable<RightWrongCard>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await db.RightWrongCards.ToListAsync();
        }

        public override async Task<RightWrongCard> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            return await db.RightWrongCards.FirstOrDefaultAsync(rwc => rwc.Id == id);
        }

        public override void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(RightWrongCard entity)
        {
            throw new NotImplementedException();
        }
    }
}
