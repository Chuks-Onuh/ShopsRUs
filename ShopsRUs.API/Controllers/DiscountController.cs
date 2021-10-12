using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ShopsRUs.API.DTOs;
using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.LoggerService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopsRUs.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IRepositoryManager _Repository;
        private readonly ILoggerManager _Logger;
        private readonly IMapper _Mapper;

        public DiscountController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IConfiguration configuration)
        {
            _Repository = repository;
            _Logger = logger;
            _Mapper = mapper;
        }

        [HttpPost("AddDiscount")]
        public async Task<IActionResult> AddDiscount([FromBody] DiscountForCreationDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ApiResponse.Failure("", new List<string> { "Invalid discount" }));

            var discount = _Mapper.Map<Discount>(model);
            _Repository.Discount.AddDiscountAsync(discount);

            var resp = await _Repository.SaveAsync();

            var response = _Mapper.Map<DiscountForCreationDto>(discount);

            if (resp > 0)
                return Ok(ApiResponse.Success(response, null));

            return BadRequest(ApiResponse.Failure(""));
        }

        [HttpGet("Discounts")]
        public async Task<IActionResult> GetDiscounts([FromQuery] PaginatedParameters paginatedParameters)
        {
            var discounts = await _Repository.Discount.DiscountsAsync(false, paginatedParameters);

            if (discounts == null)
                return BadRequest(ApiResponse.Failure("No discount available"));

            var metadate = new PaginationDto
            {
                TotalCount = discounts.TotalCount,
                HasNextPage = discounts.HasNext,
                HasPreviousPage = discounts.HasPrevious,
                TotalPages = discounts.TotalPages,
                Page = discounts.CurrentPage,
                PageSize = discounts.PageSize

            };
           
            return Ok(ApiResponse.Success(discounts, metadate));
        }

        [HttpGet("DiscountByType")]
        public async Task<IActionResult> GetDiscountByType([FromQuery] string discountType)
        {
            if (string.IsNullOrEmpty(discountType))
                return BadRequest(ApiResponse.Failure("Discount type was not provided"));

            var discount = await _Repository.Discount.GetDiscountByTypeAsync(discountType);

            if (discount == null)
                return BadRequest(ApiResponse.Failure("Discount not found"));
            
            return Ok(ApiResponse.Success(discount, null));
        }
    }
}
