using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.Contracts.Repository;
using ShopsRUs.Infrastructure.DBContext;
using System.Threading.Tasks;

namespace Sterling.Fusion.Community.Infrastructure.DataAccess.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _DbContext;
        private IAppUserRepository _AppUser;
        private IDiscountRepository _Discount;
        private IProductRepository _Product;
        public RepositoryManager(AppDbContext dbcontext) => _DbContext = dbcontext;


        public IAppUserRepository AppUser
        {
            get
            {
                if (_AppUser == null)
                    _AppUser = new AppUserRepository(_DbContext);

                return _AppUser;
            }
        }

        public IDiscountRepository Discount
        {
            get
            {
                if (_Discount == null)
                    _Discount = new DiscountRepository(_DbContext);

                return _Discount;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_Product == null)
                    _Product = new ProductRepository(_DbContext);

                return _Product;
            }
        }
        public async Task<int> SaveAsync() => await _DbContext.SaveChangesAsync();
      
    }
}
