using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Events.Sales;

public class SaleCancelledEvent : BaseEvent
{
    public SaleCancelledEvent(Sale sale) : base("Sale")
    {
        Id = sale.Id;
        CancelledAt = sale.CancelledAt ?? DateTime.UtcNow;
    }

    public int Id { get; set; }
    public DateTimeOffset CancelledAt { get; set; }
}
