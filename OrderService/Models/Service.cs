namespace OrderService.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        public Guid PartnerId { get; set; }
        public string CategoryName { get; set; } = default!;
        public long EventNumber { get; set; }
    }
}
