using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Interface
{
    public interface IRepositoryManager
    {
        IAppUserRepository AppUser { get; }
        IDiscountRepository Discount { get; }
        IProductRepository Product { get; }
        Task<int> SaveAsync();
    }
}
