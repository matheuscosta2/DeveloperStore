using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Events.Sales;

public class SaleCreatedEvent : BaseEvent
{
    public SaleCreatedEvent(Sale sale) : base("Sale")
    {
        Id = sale.Id;
        Date = sale.Date;
    }

    public int Id { get; set; }
    public DateTimeOffset Date { get; set; }
}
