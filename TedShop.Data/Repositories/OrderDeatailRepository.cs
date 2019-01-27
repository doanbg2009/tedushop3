using TedShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IOrderDeatailRepository : IRepository<OrderDetail>
    {
    }

    public class OrderDeatailRepository : RepositoryBase<OrderDetail>, IOrderDeatailRepository
    {
        public OrderDeatailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
