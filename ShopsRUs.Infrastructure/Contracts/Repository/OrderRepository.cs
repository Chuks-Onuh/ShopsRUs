using Microsoft.EntityFrameworkCore;
using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.DataAccess.Repository;
using ShopsRUs.Infrastructure.DBContext;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context) { }

        public void CreateOrder(Order order) => Create(order);
        
        public async Task<Order> GetOrder(int orderId) => await FindByCondition(x => x.Id == orderId, false).FirstOrDefaultAsync();
        
    }
}
