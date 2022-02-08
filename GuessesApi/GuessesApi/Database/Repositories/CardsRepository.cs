using GuessesApi.Database.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Repositories
{
    public class CardsRepository : BaseRepository<Card>
    {
        public CardsRepository(DataContext db) : base(db)
        {

        }

        public override async Task<Card> Create(Card entity)
        {
            await db.Cards.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public override async Task<IEnumerable<Card>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await db.Cards.ToListAsync();
        }

        public override async Task<Card> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            return await db.Cards.FirstOrDefaultAsync(card => card.Id == id);
        }

        public override void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Card entity)
        {
            throw new NotImplementedException();
        }
    }
}
