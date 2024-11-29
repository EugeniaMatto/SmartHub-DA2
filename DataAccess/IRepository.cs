using System.Linq.Expressions;

namespace SmartHub.DataAccess;

public interface IRepository<TEntity>
    where TEntity : class
{
    bool Exist(Expression<Func<TEntity, bool>> expression);

    void Add(TEntity entity);

    public IQueryable<TEntity> GetAll(
        Expression<Func<TEntity, bool>>? predicate = null,
        params Expression<Func<TEntity, object>>[] includes);

    public TEntity Get(
        Expression<Func<TEntity, bool>> predicate,
        params Expression<Func<TEntity, object>>[] includeProperties);

    void Remove(TEntity entity);

    void Update(TEntity entity);

    public TEntity? GetOrDefault(
        Expression<Func<TEntity, bool>> predicate,
        params Expression<Func<TEntity, object>>[] includes);
}
