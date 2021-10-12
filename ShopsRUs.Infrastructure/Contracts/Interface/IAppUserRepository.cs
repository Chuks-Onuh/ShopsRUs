using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.DataAccess.Repository;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Interface
{
    public interface IAppUserRepository
    {
        Task<PagedList<AppUser>> GetCustomersAsync(bool trackchanges, PaginatedParameters paginatedParameter);
        void AddCustomerAsync(AppUser customer);
        Task<AppUser> GetCustomerByIdAsync(int customerId);
        Task<AppUser> GetCustomerByNameAsync(string customerName);
    }
}
