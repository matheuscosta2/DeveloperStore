using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Events.Sales;

public class SaleItemCancelledEvent : BaseEvent
{
    public SaleItemCancelledEvent(SaleItem saleItem) : base("Sale")
    {
        SaleId = saleItem.SaleId;
        SaleItemId = saleItem.Id;
        Sequence = saleItem.Sequence;
        CancelledAt = saleItem.CancelledAt ?? DateTimeOffset.Now;
    }

    public int SaleId { get; set; }
    public int SaleItemId { get; set; }
    public short Sequence { get; set; }
    public DateTimeOffset CancelledAt { get; set; }
}
