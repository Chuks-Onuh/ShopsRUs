using System.Collections.Generic;

namespace ShopsRUs.Domain.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AppUser> AppUser { get; set; }

    }
}