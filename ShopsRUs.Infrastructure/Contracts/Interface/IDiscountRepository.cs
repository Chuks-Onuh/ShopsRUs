using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.DataAccess.Repository;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Interface
{
    public interface IDiscountRepository
    {
        Task<PagedList<Discount>> DiscountsAsync(bool trackchanges, PaginatedParameters paginatedParameter);
        void AddDiscountAsync(Discount discount);
        Task<Discount> GetDiscountByTypeAsync(string discountType);
    }
}
