using GuessesApi.Database.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(DataContext db) : base(db)
        {

        }

        public override async Task<User> Create(User entity)
        {
            await db.Users.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public override async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await db.Users.ToListAsync();
        }

        public override async Task<User> GetAsync(int id, CancellationToken cancellationToken = default)
        {
            return await db.Users.FirstOrDefaultAsync(usr => usr.Id == id);
        }

        public override void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
