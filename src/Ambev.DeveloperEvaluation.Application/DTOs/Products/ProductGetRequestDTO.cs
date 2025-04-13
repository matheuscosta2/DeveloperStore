using Ambev.DeveloperEvaluation.Application.DTOs.Common;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Products;

public record ProductGetRequestDTO : PagedRequestDTO
{
    public int? Id { get; init; }
    public string? Title { get; init; }
    public string? Category { get; init; }
    [FromQuery(Name = "_minPrice")]
    public decimal? MinPrice { get; init; }
    [FromQuery(Name = "_maxPrice")]
    public decimal? MaxPrice { get; init; }
    public bool? IsActive { get; init; }
    public DateTimeOffset? StartDate { get; init; }
    public DateTimeOffset? EndDate { get; init; }
}
