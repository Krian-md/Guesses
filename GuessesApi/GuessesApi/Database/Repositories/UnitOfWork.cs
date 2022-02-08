using GuessesApi.Database.Enteties;
using GuessesApi.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuessesApi.Database.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        DataContext db;
        readonly Lazy<IRepository<Card>> _cardsRepository;
        readonly Lazy<IRepository<Dictionary>> _dictionaryRepository;
        readonly Lazy<IRepository<Result>> _resultsRepository;
        readonly Lazy<IRepository<RightWrongCard>> _rightWrongCardsRepository;
        readonly Lazy<IRepository<User>> _usersRepository;
        public IRepository<Card> CardsRepository => _cardsRepository.Value;
        public IRepository<Dictionary> DictionaryRepository => _dictionaryRepository.Value;
        public IRepository<Result> ResultsRepository => _resultsRepository.Value;
        public IRepository<RightWrongCard> RightWrongCardsRepository => _rightWrongCardsRepository.Value;
        public IRepository<User> UsersRepository => _usersRepository.Value;
        public UnitOfWork(DataContext context)
        {
            this.db = context;
            _cardsRepository = new Lazy<IRepository<Card>>(() => new CardsRepository(context));
            _dictionaryRepository = new Lazy<IRepository<Dictionary>>(() => new DictionaryRepository(context));
            _resultsRepository = new Lazy<IRepository<Result>>(() => new ResultsRepository(context));
            _rightWrongCardsRepository = new Lazy<IRepository<RightWrongCard>>(() => new RightWrongCardsRepository(context));
            _usersRepository = new Lazy<IRepository<User>>(() => new UsersRepository(context));
        }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return db.SaveChangesAsync();
        }
    }
}
