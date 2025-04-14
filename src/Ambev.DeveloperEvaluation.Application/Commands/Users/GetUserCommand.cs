using Ambev.DeveloperEvaluation.Application.Results.Users;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Commands.Users;

public record GetUserCommand : IRequest<GetUserResult>
{
    public GetUserCommand(int id)
    {
        Id = id;
    }

    public int Id { get; init; }
}
