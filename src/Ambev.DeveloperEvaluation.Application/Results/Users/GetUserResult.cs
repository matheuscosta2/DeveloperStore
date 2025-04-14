using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Results.Users;

public record GetUserResult
{
    public int Id { get; init; }
    public string? Username { get; init; }
    public UserName? Name { get; init; }
    public UserAddress? Address { get; set; }
    public string? Email { get; init; }
    public string? Phone { get; init; }
    public UserRole Role { get; init; }
    public UserStatus Status { get; init; }
}
