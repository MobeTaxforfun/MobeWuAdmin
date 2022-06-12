using System.Linq.Expressions;

namespace MobeAdmin.API.Domain.Repository
{
    public interface IBaseMSSQLRepository<TEntity, TKey> where TEntity : class
    {
        TKey Create(TEntity Entity);
        void Update(TEntity Entity);
        void Delete(TKey Id);
        TEntity FindById(TKey Id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> Expression);
    }
}
