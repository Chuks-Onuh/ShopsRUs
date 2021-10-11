using ShopsRUs.Domain.Models;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Interface
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        Task<Order> GetOrder(int orderId);
    }
}
