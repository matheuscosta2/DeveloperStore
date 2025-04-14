using Ambev.DeveloperEvaluation.Application.Commands.Auth;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Validators.Auth;

public class AuthenticateUserCommandValidator : AbstractValidator<AuthenticateUserCommand>
{
    public AuthenticateUserCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(6);
    }
}
