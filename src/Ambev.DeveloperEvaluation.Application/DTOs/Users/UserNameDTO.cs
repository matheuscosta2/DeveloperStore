using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Users;

[ExcludeFromCodeCoverage]
public record UserNameDTO
{
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
}
