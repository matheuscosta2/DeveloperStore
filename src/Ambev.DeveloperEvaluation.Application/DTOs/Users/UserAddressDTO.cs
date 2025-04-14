using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Users;

[ExcludeFromCodeCoverage]
public record class UserAddressDTO
{
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? Number { get; set; }
    public string? Zipcode { get; set; }
    public UserAddressGeolocationDTO? Geolocation { get; set; }
}
