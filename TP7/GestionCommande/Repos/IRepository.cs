namespace Repos
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<List<T>> GetAsync();
        Task<T> GetAsync(int id);
    }
}
