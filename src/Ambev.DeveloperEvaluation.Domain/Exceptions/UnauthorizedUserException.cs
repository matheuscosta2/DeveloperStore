using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class UnauthorizedUserException : BaseException
{
    public UnauthorizedUserException(string message) : base(message)
    {
    }
}
