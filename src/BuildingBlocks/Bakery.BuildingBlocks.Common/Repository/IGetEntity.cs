namespace Bakery.BuildingBlocks.Common.Repository;

public interface IGetEntity<TEntity> where TEntity : Entity
{
    Task<IEnumerable<TEntity>> GetAllEntitiesAsync();

    Task<TEntity> GetEntityByIdAsync(Guid id);
}