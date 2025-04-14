using Ambev.DeveloperEvaluation.Application.Results.Users;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Commands.Users;

public record CreateUserCommand : IRequest<CreateUserResult>
{
    public string? Username { get; init; }
    public string? Password { get; init; }
    public UserName? Name { get; init; }
    public UserAddress? Address { get; set; }
    public string? Phone { get; init; }
    public string? Email { get; init; }
    public UserStatus? Status { get; init; }
    public UserRole? Role { get; init; }
}
