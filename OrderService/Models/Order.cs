using NetTopologySuite.Geometries;

namespace OrderService.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid PartnerId { get; set; }
    public string ServiceType { get; set; } = default!; // yg driver or regular bang

    public string Status { get; set; } = default!; // pending_payment, active, in_progress, done_pending, dispute, completed, cancelled
    

    // Geometry nanti bisa pakai NetTopologySuite (advanced)
    public Point DestinationLocation { get; set; } = default!;
    public Point WaypointLocation { get; set; } = default!;
    public long EventNumber { get; set; }
}
public enum OrderStatus
{
    PendingPayment,
    Active,
    InProgress,
    DonePending,
    Dispute,
    Completed,
    Cancelled
}
