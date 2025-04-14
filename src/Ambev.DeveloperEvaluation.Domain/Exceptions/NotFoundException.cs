using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class NotFoundException : BaseException
{
    public NotFoundException(string message) : base(message)
    {
    }
}
