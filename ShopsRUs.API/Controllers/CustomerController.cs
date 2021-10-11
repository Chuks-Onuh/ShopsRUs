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
    public class CustomerController : ControllerBase
    {
        private readonly IRepositoryManager _Repository;
        private readonly ILoggerManager _Logger;
        private readonly IMapper _Mapper;

        public CustomerController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IConfiguration configuration)
        {
            _Repository = repository;
            _Logger = logger;
            _Mapper = mapper;
        }

        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerForCreationDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ApiResponse.Failure("", new List<string> { "Invalid customer" }));

            var customer = _Mapper.Map<AppUser>(model);
            _Repository.AppUser.AddCustomerAsync(customer);

            var resp = await _Repository.SaveAsync();

            var response = _Mapper.Map<CustomerForCreationDto>(customer);

            if (resp > 0)
                return Ok(ApiResponse.Success(response, null));

            return BadRequest(ApiResponse.Failure(""));
        }

        [HttpGet("GetCustomers")]
        public async Task<IActionResult> GetCustomers([FromQuery] PaginatedParameters paginatedParameters)
        {
            var customers = await _Repository.AppUser.GetCustomersAsync(false, paginatedParameters);

            if (customers == null)
                return BadRequest(ApiResponse.Failure("", new List<string> { "No customer found" }));

            var metadate = new PaginationDto
            {
                TotalCount = customers.TotalCount,
                HasNextPage = customers.HasNext,
                HasPreviousPage = customers.HasPrevious,
                TotalPages = customers.TotalPages,
                Page = customers.CurrentPage,
                PageSize = customers.PageSize

            };

            return Ok(ApiResponse.Success(customers, metadate));
        }

        [HttpGet("CustomerById")]
        public async Task<IActionResult> CustomerById(int customerId)
        {
            if(customerId < 0)
                return BadRequest(ApiResponse.Failure("", new List<string> { "Invalid customer Id" }));

            var customer = await _Repository.AppUser.GetCustomerById(customerId);

            if (customer == null)
                return BadRequest(ApiResponse.Failure("No customer available"));

            return Ok(ApiResponse.Success(customer, null));
        }

        [HttpGet("GetCustomerByName")]
        public async Task<IActionResult> GetCustomerByName([FromQuery] string customerName, [FromQuery] PaginatedParameters paginatedParameters)
        {
            if (string.IsNullOrEmpty(customerName))
                return BadRequest(ApiResponse.Failure("Customer name was not provided"));

            var customer = await _Repository.AppUser.GetCustomerByName(customerName, paginatedParameters);

            if (customer == null)
                return BadRequest(ApiResponse.Failure("", new List<string> { "Customer not found" }));

            var metadate = new PaginationDto
            {
                TotalCount = customer.TotalCount,
                HasNextPage = customer.HasNext,
                HasPreviousPage = customer.HasPrevious,
                TotalPages = customer.TotalPages,
                Page = customer.CurrentPage,
                PageSize = customer.PageSize

            };
            return Ok(ApiResponse.Success(customer, metadate));    
        }
    }
}
