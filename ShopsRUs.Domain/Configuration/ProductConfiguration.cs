using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Domain.Models;

namespace ShopsRUs.Domain.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Rice",
                    Category = "Groceries",
                    Amount = 300.0m
                    
                },
                new Product
                {
                    Id = 2,
                    Name = "Book",
                    Category = "Stationaries",
                    Amount = 550.0m
                }, 
                new Product
                {
                    Id = 3,
                    Name = "Plasma Televison",
                    Category = "Electronics",
                    Amount = 175450.0m
                },
                new Product
                {
                    Id = 4,
                    Name = "Hp Pavillion",
                    Category = "Hp Pavillion",
                    Amount = 500000.0m
                },
                new Product
                {
                    Id = 5,
                    Name = "PS 4",
                    Category = "Gaming",
                    Amount = 200000.0m
                },
                new Product
                {
                    Id = 6,
                    Name = "Diaper bag",
                    Category = "Baby Product",
                    Amount = 550.0m
                },
                new Product
                {
                    Id = 7,
                    Name = "Redmi Note 9",
                    Category = "Smart Phones",
                    Amount = 100000.0m
                },
                new Product
                {
                    Id = 8,
                    Name = "Rods",
                    Category = "Building",
                    Amount = 150000.0m
                },
                new Product
                {
                    Id = 9,
                    Name = "Beans",
                    Category = "Groceries",
                    Amount = 80.0m
                });
        }
    }
}
