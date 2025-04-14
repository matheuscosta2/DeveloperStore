using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Sales;

[ExcludeFromCodeCoverage]
public record SalePostRequestDTO
{
    public int UserId { get; init; }
    public int BranchId { get; init; }

    public List<SaleItemPostDTO>? Items { get; init; }
}
