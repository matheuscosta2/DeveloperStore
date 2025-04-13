using Ambev.DeveloperEvaluation.Application.DTOs.Common;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Branches;

public record BranchGetRequestDTO : PagedRequestDTO
{
    public int? Id { get; init; }
public string? Name { get; init; }
public bool? IsActive { get; init; }
public DateTimeOffset? StartDate { get; init; }
public DateTimeOffset? EndDate { get; init; }
}
