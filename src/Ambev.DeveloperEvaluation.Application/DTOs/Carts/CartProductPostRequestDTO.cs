using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

[ExcludeFromCodeCoverage]
public record CartProductPostRequestDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
