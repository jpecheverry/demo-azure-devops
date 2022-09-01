namespace Bakery.BuildingBlocks.Common.Repository;

public interface IUpdateEntity<TEntity> where TEntity : Entity
{
    Task<TEntity> UpdateEntityAsync(TEntity entity);
}