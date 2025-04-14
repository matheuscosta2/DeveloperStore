using Ambev.DeveloperEvaluation.Application.DTOs.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Carts;

[ExcludeFromCodeCoverage]
public record CartGetRequestDTO : PagedRequestDTO
{
    public int? Id { get; init; }
    public int? UserId { get; init; }
    [FromQuery(Name = "_minDate")]
    public DateTimeOffset? MinDate { get; init; }
    [FromQuery(Name = "_maxDate")]
    public DateTimeOffset? MaxDate { get; init; }
}
