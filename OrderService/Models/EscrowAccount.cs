namespace OrderService.Models
{
    public class EscrowAccount
    {
        public Guid Id { get; set; } // id seperti biasa
        public Guid OrderId { get; set; } // ada hubungan ama order juga
        public decimal Amount { get; set; } // nominal yg ditahannya

        public string Status { get; set; } = default!; // hold, release, atau frozen (ini klo ada penahanan sementara)
        public DateTime? FrozenAt { get; set; } // kapan dana ditahan (klo statusnya hold)
        public DateTime? ReleasedAt { get; set; } // kapan dana dilepas (klo statusnya release)
        public long EventNumber { get; set; }
    }
}
