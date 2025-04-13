using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class BadRequestException : BaseException
{
    public BadRequestException(string message) : base(message)
    {
    }
}
