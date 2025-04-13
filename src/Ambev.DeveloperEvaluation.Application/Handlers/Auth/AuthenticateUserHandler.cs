using Ambev.DeveloperEvaluation.Application.Commands.Auth;
using Ambev.DeveloperEvaluation.Application.Results.Auth;
using Ambev.DeveloperEvaluation.Domain.Exceptions;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Common;
using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Ambev.DeveloperEvaluation.Application.Handlers.Auth;

public class AuthenticateUserHandler : IRequestHandler<AuthenticateUserCommand, AuthenticateUserResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IValidator<AuthenticateUserCommand> _validator;

    public AuthenticateUserHandler(
        IUserRepository userRepository,
        IPasswordHasher passwordHasher,
        IJwtTokenGenerator jwtTokenGenerator,
        IValidator<AuthenticateUserCommand> validator)
    {
        _userRepository = userRepository;
        _passwordHasher = passwordHasher;
        _jwtTokenGenerator = jwtTokenGenerator;
        _validator = validator;
    }

    public async Task<AuthenticateUserResult> Handle(AuthenticateUserCommand request, CancellationToken cancellationToken)
    {
        await ValidateRequestAsync(request, cancellationToken);

        var user = await _userRepository.GetActiveByEmailAsync(request.Email!);

        if (user is null || !_passwordHasher.VerifyPassword(request.Password!, user.Password!))
            throw new UnauthorizedUserException("Email or password is invalid.");

        var token = await _jwtTokenGenerator.GenerateTokenAsync(user);

        return new AuthenticateUserResult
        {
            Id = user.Id,
            Token = token,
            Email = user.Email,
            Username = user.Username,
            Role = user.Role.ToString()
        };
    }

    private async Task ValidateRequestAsync(AuthenticateUserCommand request, CancellationToken cancellationToken)
    {
        var validation = await _validator.ValidateAsync(request, cancellationToken);

        if (!validation.IsValid)
            throw new ValidationException(validation.Errors);
    }
}
