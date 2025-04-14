using Ambev.DeveloperEvaluation.Domain.Base;
using Ambev.DeveloperEvaluation.Domain.Enums;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

[ExcludeFromCodeCoverage]
public class Sale : BaseEntity
{
    public SaleStatus Status { get; set; }
    public DateTimeOffset Date { get; set; }
    public int UserId { get; set; }
    public int BranchId { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTimeOffset? CancelledAt { get; set; }

    public virtual User? User { get; set; }
    public virtual Branch? Branch { get; set; }
    public virtual List<SaleItem>? Items { get; set; }
}
