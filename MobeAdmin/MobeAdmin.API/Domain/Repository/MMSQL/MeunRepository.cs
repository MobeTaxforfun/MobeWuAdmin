using MobeAdmin.API.Models.MSSQL.Entities;
using System.Linq.Expressions;

namespace MobeAdmin.API.Domain.Repository.MMSQL
{
    public class MeunRepository : IMeunRepository, IBaseMSSQLRepository<SysMenu, int>
    {
        private readonly MobeAdminContext mobeAdminContext;
        public MeunRepository(MobeAdminContext mobeAdminContext)
        {
            this.mobeAdminContext = mobeAdminContext;
        }

        public int Create(SysMenu Entity)
        {
            mobeAdminContext.SysMenus.Add(Entity);
            mobeAdminContext.SaveChanges();
            return Entity.Id;
        }

        public void Delete(int Id)
        {
            var entity = mobeAdminContext.SysMenus.Find(Id);
            if (entity != null)
            {
                mobeAdminContext.SysMenus.Remove(entity);
                mobeAdminContext.SaveChanges();
            }
        }

        public IEnumerable<SysMenu> Find(Expression<Func<SysMenu, bool>> Expression)
        {
            return mobeAdminContext.SysMenus.Where(Expression);
        }

        public SysMenu FindById(int Id)
        {
            return mobeAdminContext.SysMenus.SingleOrDefault(c => c.Id == Id);
        }

        public IEnumerable<SysMenu> Pagination(int page, int temsPerPage)
        {
            throw new NotImplementedException();
        }

        public void Update(SysMenu Entity)
        {
            var entity = mobeAdminContext.SysMenus.Find(Entity.Id);
            mobeAdminContext.Entry(entity).CurrentValues.SetValues(entity);
            mobeAdminContext.SaveChanges();
        }
    }

    public interface IMeunRepository
    {
        public IEnumerable<SysMenu> Pagination(int page, int temsPerPage);
    }
}
