using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

[ExcludeFromCodeCoverage]
public record CartPostRequestDTO
{
    public int UserId { get; init; }
    public DateTimeOffset Date { get; init; }
    public List<CartProductPostRequestDTO>? Products { get; init; }
}
