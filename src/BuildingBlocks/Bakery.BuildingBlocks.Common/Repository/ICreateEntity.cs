namespace Bakery.BuildingBlocks.Common.Repository;

public interface ICreateEntity<TEntity> where TEntity : Entity
{
    Task<TEntity> CreateEntityAsync(TEntity entity);
}