using System;
using System.ComponentModel.DataAnnotations;

namespace ShopsRUs.Domain.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
    }
}
