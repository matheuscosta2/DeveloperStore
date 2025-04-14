using Ambev.DeveloperEvaluation.Application.Commands.Users;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Validators.Users;

public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("User ID is required");
    }
}
