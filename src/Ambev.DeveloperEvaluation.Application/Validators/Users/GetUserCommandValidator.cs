using Ambev.DeveloperEvaluation.Application.Commands.Users;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Validators.Users;

public class GetUserCommandValidator : AbstractValidator<GetUserCommand>
{
    public GetUserCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("User ID is required");
    }
}
