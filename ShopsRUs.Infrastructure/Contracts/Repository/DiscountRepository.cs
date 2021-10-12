using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.DataAccess.Repository;
using ShopsRUs.Infrastructure.DBContext;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Repository
{
    public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(AppDbContext context) : base(context) { }

        public void AddDiscountAsync(Discount discount) => Create(discount);

        public async Task<PagedList<Discount>> DiscountsAsync(bool trackchanges, PaginatedParameters paginatedParameter)
        {
            await Task.CompletedTask;
            return PagedList<Discount>.ToPagedList(FindAll(trackchanges)
                .OrderBy(x => x.Id), paginatedParameter.PageNumber, paginatedParameter.PageSize);
        }

        public async Task<Discount> GetDiscountByTypeAsync(string discountType)
        {
            var result = FindByCondition(x => x.Name.ToLower().Contains(discountType.ToLower()), false).FirstOrDefault();

            await Task.CompletedTask;

            return result;
        }

        
    }
}
