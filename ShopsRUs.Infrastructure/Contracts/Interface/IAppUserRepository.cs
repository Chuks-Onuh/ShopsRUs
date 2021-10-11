using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.DataAccess.Repository;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Interface
{
    public interface IAppUserRepository
    {
        Task<PagedList<AppUser>> GetCustomersAsync(bool trackchanges, PaginatedParameters paginatedParameter);
        void AddCustomerAsync(AppUser customer);
        Task<AppUser> GetCustomerById(int customerId);
        Task<PagedList<AppUser>> GetCustomerByName(string customerName, PaginatedParameters paginatedParameters);
    }
}
