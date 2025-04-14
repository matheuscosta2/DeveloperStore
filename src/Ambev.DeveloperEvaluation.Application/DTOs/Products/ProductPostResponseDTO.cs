using Ambev.DeveloperEvaluation.Domain.Enums;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Products;

[ExcludeFromCodeCoverage]
public record ProductPostResponseDTO
{
    public int Id { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
    public string? Image { get; init; }
    public ProductCategory Category { get; init; }
    public decimal Price { get; init; }
    public ProductRatingDTO? Rating { get; init; }
    public bool IsActive { get; init; }
}
