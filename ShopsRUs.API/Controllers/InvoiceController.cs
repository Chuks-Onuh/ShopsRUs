using Microsoft.AspNetCore.Mvc;
using ShopsRUs.API.DTOs;
using ShopsRUs.API.Services;
using ShopsRUs.Infrastructure;
using ShopsRUs.Infrastructure.Contracts.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IRepositoryManager _Repository;

        public InvoiceController(IRepositoryManager repository)
        {
            _Repository = repository;
        }

        [HttpPost("{userid}")]
        public async Task<IActionResult> CalculateDiscount(int userid, [FromBody] IEnumerable<OrderDto> model)
        {
            var user = await _Repository.AppUser.GetCustomerByIdAsync(userid);

            var discount = await _Repository.Discount.GetDiscountByTypeAsync(user.Role.Name);

            var products = await _Repository.Product.GetProductsAsync(model.Select(x => x.ProductId), false);

            var result = products.Select(x => new Item
            {
                Category = x.Category,
                ProductId = x.Id,
                Amount = x.Amount,
                Quantity = model.FirstOrDefault(m => m.ProductId == x.Id).Quantity
            }).ToList();

            var calculateDiscount = InvoiceService.GetInvoiceAmount(user, result, discount);
            return Ok(ApiResponse.Success($"Total invoice amount to pay is: ${calculateDiscount}", null));

        }
    }
}
