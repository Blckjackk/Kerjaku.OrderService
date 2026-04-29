namespace OrderService.Models
{
    public class Dispute
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid RaisedBy { get; set; } // ini bisa user atau partner, tergantung siapa yang raise dispute

        public string Reason { get; set; } = default!; // alasan kenapa dispute di raise, bisa berupa free text
        public string Status { get; set; } = default!; // pending, resolved, rejected

        public Guid? AdminId { get; set; } // admin yang menangani dispute ini, bisa null kalau belum ada yang handle
        public DateTime? Deadline { get; set; } // batas waktu untuk menyelesaikan dispute, bisa null kalau belum ditentukan
        public long EventNumber { get; set; }
    }
}
