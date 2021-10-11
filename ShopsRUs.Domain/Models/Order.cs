

namespace ShopsRUs.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ProductAmount { get; set; }
        public float DiscountRate { get; set; }
        public int ProductId { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
