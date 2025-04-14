using Ambev.DeveloperEvaluation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.DTOs.Users;

[ExcludeFromCodeCoverage]
public record UserPostRequestDTO
{
    public string? Username { get; init; }
    public string? Password { get; init; }
    public string? Phone { get; init; }
    public UserNameDTO? Name { get; set; }
    public UserAddressDTO? Address { get; init; }
    public string? Email { get; init; }
    public UserStatus? Status { get; init; }
    public UserRole? Role { get; init; }
}
