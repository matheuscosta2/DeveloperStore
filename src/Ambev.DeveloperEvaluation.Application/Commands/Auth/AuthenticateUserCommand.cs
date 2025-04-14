using Ambev.DeveloperEvaluation.Application.Results.Auth;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Commands.Auth;

public record AuthenticateUserCommand : IRequest<AuthenticateUserResult>
{
    public string? Email { get; init; }
    public string? Password { get; init; }
}
