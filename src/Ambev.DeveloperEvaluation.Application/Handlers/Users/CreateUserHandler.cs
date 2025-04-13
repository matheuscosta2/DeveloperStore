using Ambev.DeveloperEvaluation.Application.Commands.Users;
using Ambev.DeveloperEvaluation.Application.Results.Users;
using Ambev.DeveloperEvaluation.Domain.Exceptions;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Ambev.DeveloperEvaluation.Application.Handlers.Users;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, CreateUserResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IValidator<CreateUserCommand> _validator;
    public CreateUserHandler(IUserRepository userRepository,
                             IPasswordHasher passwordHasher,
                             IValidator<CreateUserCommand> validator)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _validator = validator;
    }

    public async Task<CreateUserResult> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        await ValidateUserAsync(command, cancellationToken);

        var result = await _userRepository.GetActiveByEmailAsync(command.Email!);

        if (result is not null)
            throw new UserAlreadyExistsException($"User with email {command.Email} already exists");

        var user = command.ToEntity();

        user.Password = _passwordHasher.HashPassword(command.Password!);

        var createdUser = await _userRepository.AddAsync(user);

        return createdUser.ToCreateResult();
    }

    private async Task ValidateUserAsync(CreateUserCommand command, CancellationToken cancellationToken)
    {
        var validation = await _validator.ValidateAsync(command, cancellationToken);

        if (!validation.IsValid)
            throw new ValidationException(validation.Errors);
    }
}
