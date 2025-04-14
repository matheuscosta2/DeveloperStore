using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.BranchProducts;

[ExcludeFromCodeCoverage]
public record BranchProductPutRequestDTO
{
    public int Id { get; init; }
    public decimal Price { get; init; }
    public int StockQuantity { get; init; }
    public bool IsActive { get; init; }
}
