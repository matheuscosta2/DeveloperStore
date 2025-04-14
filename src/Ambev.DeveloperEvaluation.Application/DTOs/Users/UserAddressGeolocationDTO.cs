using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Users;

[ExcludeFromCodeCoverage]
public record UserAddressGeolocationDTO
{
    public string? Lat { get; set; }
    public string? Long { get; set; }
}
