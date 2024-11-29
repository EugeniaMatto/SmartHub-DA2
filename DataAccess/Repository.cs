using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SmartHub.DB;

namespace SmartHub.DataAccess;
[ExcludeFromCodeCoverage]
public sealed class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class
{
    private readonly DbSet<TEntity> _entities;

    private readonly SmartHubAPIContext _context;

    public Repository(SmartHubAPIContext context)
    {
        _context = context;
        _entities = context.Set<TEntity>();
    }

    public bool Exist(Expression<Func<TEntity, bool>> predicate)
    {
        return _entities.Any(predicate);
    }

    public void Add(TEntity entity)
    {
        _entities.Add(entity);

        _context.SaveChanges();
    }

    public IQueryable<TEntity> GetAll(
        Expression<Func<TEntity, bool>>? predicate = null,
        params Expression<Func<TEntity, object>>[] includes)
    {
        IQueryable<TEntity> query = _entities;

        foreach (var include in includes)
        {
            query = query.Include(include);
        }

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        return query;
    }

    public TEntity Get(
        Expression<Func<TEntity, bool>> predicate,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _entities;

        if (includeProperties != null)
        {
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
        }

        var entity = query.FirstOrDefault(predicate);

        if (entity == null)
        {
            throw new InvalidOperationException($"{typeof(TEntity).Name} not found");
        }

        return entity;
    }

    public void Remove(TEntity entity)
    {
        _entities.Remove(entity);

        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _entities.Update(entity);

        _context.SaveChanges();
    }

    public TEntity? GetOrDefault(
    Expression<Func<TEntity, bool>> predicate,
    params Expression<Func<TEntity, object>>[] includes)
    {
        IQueryable<TEntity> query = _entities;

        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }

        return query.FirstOrDefault(predicate);
    }
}
