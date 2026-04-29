namespace OrderService.Models
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid RaterId { get; set; }
        public Guid RateeId { get; set; }

        public int Score { get; set; } // 1–5
        public string Review { get; set; } = default!;

        public bool IsDefault { get; set; }
        public long EventNumber { get; set; }
    }
}
