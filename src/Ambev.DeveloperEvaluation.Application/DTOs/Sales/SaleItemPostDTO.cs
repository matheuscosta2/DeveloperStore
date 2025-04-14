using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Sales;

[ExcludeFromCodeCoverage]
public record SaleItemPostDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
    public decimal? Discount { get; init; }
}
