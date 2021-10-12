using Microsoft.EntityFrameworkCore;
using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.DataAccess.Repository;
using ShopsRUs.Infrastructure.DBContext;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Repository
{
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(AppDbContext context) : base(context) { }

        public void AddCustomerAsync(AppUser customer) => Create(customer);

        public async Task<PagedList<AppUser>> GetCustomersAsync(bool trackchanges, PaginatedParameters paginatedParameter)
        {
            await Task.CompletedTask;
            return PagedList<AppUser>.ToPagedList(FindAll(trackchanges)
                .OrderBy(x => x.Id), paginatedParameter.PageNumber, paginatedParameter.PageSize);
        }

        public async Task<AppUser> GetCustomerByIdAsync(int customerId)
        {
            var customer = await FindByCondition(x => x.Id == customerId, false).Include(x => x.Role).FirstOrDefaultAsync();
            return customer;
        }

        public async Task<AppUser> GetCustomerByNameAsync(string customerName)
        {
            var customer = FindByCondition((x => x.FirstName.ToLower()
                         .Contains(customerName.ToLower()) || x.LastName.ToLower()
                         .Contains(customerName.ToLower())), false).FirstOrDefault();
           
            await Task.CompletedTask;
            return customer;
        }
    }
}
