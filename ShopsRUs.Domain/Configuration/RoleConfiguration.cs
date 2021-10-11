using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopsRUs.Domain.Models;

namespace ShopsRUs.Domain.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = 1,
                    Name = "Employee"
                },
                new Role
                {
                     Id = 2,
                     Name = "Affiliate"
                },
                new Role
                {
                    Id = 3,
                    Name = "Customer"
                });
        }
    }
}
