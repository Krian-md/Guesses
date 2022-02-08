using GuessesApi.Database.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<Card> CardsRepository { get; }
        public IRepository<Dictionary> DictionaryRepository { get; }
        public IRepository<Result> ResultsRepository { get; }
        public IRepository<RightWrongCard> RightWrongCardsRepository { get; }
        public IRepository<User> UsersRepository { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        
    }
}
