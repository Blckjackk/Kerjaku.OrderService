namespace OrderService.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public long EventNumber { get; set; } // untuk tracking perubahan data user, bisa dipakai untuk optimistik concurrency control juga
        public string Role { get; set; } = default!; // customer, partner, admin
        public string Status { get; set; } = default!; // active, suspended, banned
    }
}
