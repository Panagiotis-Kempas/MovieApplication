using MovieApplication.Database;
using MovieApplication.Persistence.IRepositories;
using MovieApplication.Persistence.Repositories;

namespace MovieApplication.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext db)
        {
            _context = db;
            Actors = new ActorRepository(_context);
           Movies = new MovieRepository(_context);
        }
        public IActorRepository Actors { get; private set; }

        public IMovieRepository Movies { get; private set; }
       
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
