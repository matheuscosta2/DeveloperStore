using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Events.Sales;

public class SaleUpdatedEvent : BaseEvent
{
    public SaleUpdatedEvent(Sale sale) : base("Sale")
    {
        Id = sale.Id;
        UpdatedAt = sale.UpdatedAt;
    }

    public int Id { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}
