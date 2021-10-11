using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Interface
{
    public interface IRepositoryManager
    {
        IAppUserRepository AppUser { get; }
        IDiscountRepository Discount { get; }
        IProductRepository Product { get; }
        IOrderRepository Order { get; }
        Task<int> SaveAsync();
    }
}
