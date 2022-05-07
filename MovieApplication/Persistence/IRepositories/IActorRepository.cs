using MovieApplication.Models.Entities;

namespace MovieApplication.Persistence.IRepositories
{
    public interface IActorRepository : IRepository<Actor>
    {
        IEnumerable<Actor> GetActorsByName(string name);

        IEnumerable<Actor> AllActors();

    }
}
