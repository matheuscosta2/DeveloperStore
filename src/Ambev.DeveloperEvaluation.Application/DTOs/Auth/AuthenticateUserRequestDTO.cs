using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Auth;
[ExcludeFromCodeCoverage]
public record AuthenticateUserRequestDTO
{
    public string? Email { get; set; }
    public string? Password { get; set; }
}
