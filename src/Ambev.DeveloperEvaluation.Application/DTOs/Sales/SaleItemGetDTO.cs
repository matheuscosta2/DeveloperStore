using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Sales;

[ExcludeFromCodeCoverage]
public record SaleItemGetDTO
{
    public short Sequence { get; init; }
    public int ProductId { get; init; }
    public string? ProductName { get; init; }
    public int Quantity { get; init; }
    public decimal Price { get; init; }
    public decimal? Discount { get; init; }
    public bool IsCancelled { get; init; }
}
