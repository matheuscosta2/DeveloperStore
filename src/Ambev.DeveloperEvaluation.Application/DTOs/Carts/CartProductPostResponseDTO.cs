using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

[ExcludeFromCodeCoverage]
public record CartProductPostResponseDTO
{
    public int ProductId { get; init; }
    public int Quantity { get; init; }
}
