namespace OrderService.Models
{
    public class Invoice
    {
        public Guid Id { get; set; } // buat id invoicenya
        public Guid OrderId { get; set; } // ini dia kan ada hubungan dengan Order
        public decimal Amount { get; set; } // jumlah harganya 

        public string Description { get; set; } = default!; // deskripsi dari tugas tugasnya nanti disini juga
        public DateTime? ScheduleStart { get; set; } // start mulai si kerjaannya

        public string PaymentLink { get; set; } = default!; // ini buat link pembayaran karna kita make xendit kan ya
        public string Status { get; set; } = default!; // statusnya buat sudah bayar ato blm
        public long EventNumber { get; set; }
    }
}
