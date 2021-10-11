using System;
using System.ComponentModel.DataAnnotations;

namespace ShopsRUs.Domain.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
