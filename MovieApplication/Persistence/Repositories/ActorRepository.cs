using MovieApplication.Database;
using MovieApplication.Models.Entities;
using MovieApplication.Persistence.IRepositories;

namespace MovieApplication.Persistence.Repositories
{
    public class ActorRepository : Repository<Actor>,IActorRepository
    {
        public ActorRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;


        public IEnumerable<Actor> GetActorsByName(string name)
        {
            var actors = ApplicationDbContext.Actors.Where(actor => actor.FirstName == name);
            return actors;
        }



    }
}
