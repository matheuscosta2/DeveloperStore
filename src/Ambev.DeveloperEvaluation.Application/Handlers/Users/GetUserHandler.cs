using Ambev.DeveloperEvaluation.Application.Commands.Users;
using Ambev.DeveloperEvaluation.Application.Mappers.Users;
using Ambev.DeveloperEvaluation.Application.Results.Users;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Handlers.Users;

public class GetUserHandler : IRequestHandler<GetUserCommand, GetUserResult?>
{
    private readonly IUserRepository _userRepository;
    private readonly IValidator<GetUserCommand> _validator;
    public GetUserHandler(IUserRepository userRepository, IValidator<GetUserCommand> validator)
    {
        _userRepository = userRepository;
        _validator = validator;
    }

    public async Task<GetUserResult?> Handle(GetUserCommand request, CancellationToken cancellationToken)
    {
        await ValidateRequestAsync(request, cancellationToken);

        var user = await _userRepository.GetByIdAsync(request.Id);

        return user?.ToGetResult();
    }

    private async Task ValidateRequestAsync(GetUserCommand request, CancellationToken cancellationToken)
    {
        var validation = await _validator.ValidateAsync(request, cancellationToken);

        if (!validation.IsValid)
            throw new ValidationException(validation.Errors);
    }
}
