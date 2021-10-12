using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using ShopsRUs.API.Controllers;
using ShopsRUs.Domain.Models;
using ShopsRUs.Infrastructure.Contracts.Interface;
using ShopsRUs.Infrastructure.LoggerService;
using System;
using System.Threading.Tasks;
using Xunit;

namespace ShopsRUs.Tests
{
    public class CustomerControllerTest
    {
        private readonly CustomerController _customer;
        private readonly Mock<IRepositoryManager> _customerRepoMock = new Mock<IRepositoryManager>();
        private readonly Mock<ILoggerManager> _logger = new Mock<ILoggerManager>();
        private readonly Mock<IMapper> _mapper = new Mock<IMapper>();
        private readonly Mock<IConfiguration> _config = new Mock<IConfiguration>();
        public CustomerControllerTest()
        {
            _customer = new CustomerController(_customerRepoMock.Object, _logger.Object, _mapper.Object, _config.Object);
        }

        [Fact]
        public async Task GetByIdAsync()
        {
            // Arrange
            int Id = 1;

            var customer = new AppUser
            {
                Id = Id,
                FirstName = "John"
            };

            _customerRepoMock.Setup(x => x.AppUser.GetCustomerById(Id)).ReturnsAsync(customer);

            // Act
            var res = await _customer.CustomerById(Id);
            var result = (res.Result as OkObjectResult).Value as AppUser;

            //Assert
            Assert.Equal(result.Id, Id);
        }
    }
}
