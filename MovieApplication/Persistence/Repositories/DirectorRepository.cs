using MovieApplication.Database;
using MovieApplication.Models.Entities;
using MovieApplication.Persistence.IRepositories;

namespace MovieApplication.Persistence.Repositories
{
    public class DirectorRepository : Repository<Director>,IDirectorRepository
    {
        public DirectorRepository(ApplicationDbContext context)
             : base(context)
        {
        }
        public ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;

    }
}
