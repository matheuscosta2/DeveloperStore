using Ambev.DeveloperEvaluation.Application.DTOs.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Sales;

[ExcludeFromCodeCoverage]
public record SaleGetRequestDTO : PagedRequestDTO
{
    public int? Id { get; init; }
    public int? UserId { get; init; }
    public int? BranchId { get; init; }
    public SaleStatus? Status { get; init; }
    public DateTimeOffset? StartDate { get; init; }
    public DateTimeOffset? EndDate { get; init; }
}
