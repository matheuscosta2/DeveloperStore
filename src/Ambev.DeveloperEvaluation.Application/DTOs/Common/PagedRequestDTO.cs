using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Common;

[ExcludeFromCodeCoverage]
public record PagedRequestDTO
{
    [FromQuery(Name = "_page")]
    public int Page { get; set; } = 1;

    [FromQuery(Name = "_size")]
    public int Size { get; set; } = 10;

    [FromQuery(Name = "_order")]
    public string? OrderByClause { get; set; } = default;
}
