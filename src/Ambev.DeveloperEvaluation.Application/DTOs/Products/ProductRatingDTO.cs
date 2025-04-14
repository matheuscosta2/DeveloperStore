using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Products;

[ExcludeFromCodeCoverage]
public record ProductRatingDTO
{
    public double? Rate { get; init; }
    public int? Count { get; init; }
}
