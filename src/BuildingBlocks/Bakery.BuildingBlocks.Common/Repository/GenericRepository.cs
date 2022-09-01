
namespace Bakery.BuildingBlocks.Common.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where  TEntity : Entity
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> GetAllEntitiesAsync()
    {
        IEnumerable<TEntity> query = _dbSet;
        return query;
    }

    public async Task<TEntity> GetEntityByIdAsync(Guid id)
    {
        TEntity entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public async Task<TEntity> CreateEntityAsync(TEntity entity)
    {
        EntityEntry<TEntity> entityEntry = await _dbSet.AddAsync(entity);
        return entityEntry.Entity;
    }

    public async Task<TEntity> UpdateEntityAsync(TEntity entity)
    {
        EntityEntry<TEntity> entityEntry = _dbSet.Update(entity);
        return entityEntry.Entity;
    }

    public async Task<TEntity> RemoveEntityAsync(TEntity entity)
    {
        EntityEntry<TEntity> entityEntry = _dbSet.Remove(entity);
        return entityEntry.Entity;
    }
}