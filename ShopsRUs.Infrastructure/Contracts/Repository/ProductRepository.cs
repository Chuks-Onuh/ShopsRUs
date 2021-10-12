using Microsoft.EntityFrameworkCore;
using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.DataAccess.Repository;
using ShopsRUs.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> GetProductsAsync(IEnumerable<int> productIds, bool trackChanges) =>
            await FindAll(false).Where(x => productIds.Contains(x.Id)).ToListAsync();

        
    }
}
