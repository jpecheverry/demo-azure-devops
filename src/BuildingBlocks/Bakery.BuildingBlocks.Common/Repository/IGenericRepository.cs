namespace Bakery.BuildingBlocks.Common.Repository;

public interface IGenericRepository<TEntity> : IGetEntity<TEntity>, ICreateEntity<TEntity>
                                                ,IUpdateEntity<TEntity>, IDeleteEntity<TEntity>
                            where TEntity : Entity
{

}
