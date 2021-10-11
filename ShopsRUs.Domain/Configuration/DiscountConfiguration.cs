using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Domain.Models;

namespace ShopsRUs.Domain.Configuration
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasData(
                new Discount
                {
                    Id = 1,
                    Name = "Employee",
                    Rate = 0.3m,
                    CreatedAt = System.DateTime.Now
                },
                new Discount
                {
                    Id = 2,
                    Name = "Affiliate",
                    Rate = 0.1m,
                    CreatedAt = System.DateTime.Now
                },
                new Discount
                {
                    Id = 3,
                    Name = "Customer",
                    Rate = 0.05m,
                    CreatedAt = System.DateTime.Now
                });
        }
    }
}