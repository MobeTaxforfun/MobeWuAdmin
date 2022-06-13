using MobeAdmin.API.Domain.Repository.MMSQL;

namespace MobeAdmin.API.Domain.Service
{
    public class MenuService : IMenuService
    {
        private readonly IMeunRepository meunRepository;
        public MenuService(IMeunRepository meunRepository)
        {
            this.meunRepository = meunRepository;
        }
    }

    public interface IMenuService
    {
      
    }
}
