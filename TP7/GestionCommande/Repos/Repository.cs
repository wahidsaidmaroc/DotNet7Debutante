
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace Repos;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly FormationOumdinAcademyContext _dbContext;
    
    private DbSet<T> _dbSet;
    private DbSet<T> DbSet => _dbSet ??= _dbContext.Set<T>();
    public Repository(FormationOumdinAcademyContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(T entity)
    {
        DbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        DbSet.Remove(entity);
    }

    public async Task<List<T>> GetAsync()
    {
        return await DbSet.ToListAsync<T>();
    }

    public Task<T> GetAsync(int id)
    {
        return null;
        //throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        DbSet.Update(entity);
    }
}
