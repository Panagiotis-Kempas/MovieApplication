namespace MovieApplication.Models.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        Task<T> GetByiD(Guid id);

        Task<bool> Add(T entity);

        Task<bool> Update(T entity);
        Task<bool> Delete(Guid id);
    }
}
