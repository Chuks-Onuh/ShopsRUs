﻿using ShopsRUs.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsRUs.Infrastructure.Contracts.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts(IEnumerable<int> productIds, bool trackChanges);
    }
}
