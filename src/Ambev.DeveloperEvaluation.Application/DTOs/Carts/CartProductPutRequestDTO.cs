using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

[ExcludeFromCodeCoverage]
public record CartProductPutRequestDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
