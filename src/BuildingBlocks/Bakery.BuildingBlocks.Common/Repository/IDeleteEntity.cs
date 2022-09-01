namespace Bakery.BuildingBlocks.Common.Repository;

public interface IDeleteEntity<TEntity> where TEntity : Entity
{
    Task<TEntity> RemoveEntityAsync(TEntity entity);
}