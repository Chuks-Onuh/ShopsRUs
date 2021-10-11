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
        

        public async Task<AppUser> GetCustomerById(int customerId)
        {
            var customer = await FindByCondition(x => x.Id == customerId, false).Include(x => x.Role).FirstOrDefaultAsync();
            return customer;
        }

        public async Task<PagedList<AppUser>> GetCustomerByName(string customerName, PaginatedParameters paginatedParameters)
        {
            var result = FindByCondition((x => x.FirstName.ToLower()
                         .Contains(customerName.ToLower()) || x.LastName.ToLower()
                         .Contains(customerName.ToLower())), false);
           
            await Task.CompletedTask;
            return PagedList<AppUser>.ToPagedList(result, paginatedParameters.PageNumber, paginatedParameters.PageSize);
        }

        public async Task<PagedList<AppUser>> GetCustomersAsync(bool trackchanges, PaginatedParameters paginatedParameter)
        {
            await Task.CompletedTask;
            return PagedList<AppUser>.ToPagedList(FindAll(trackchanges)
                .OrderBy(x => x.Id), paginatedParameter.PageNumber, paginatedParameter.PageSize);
        }
    }
}
