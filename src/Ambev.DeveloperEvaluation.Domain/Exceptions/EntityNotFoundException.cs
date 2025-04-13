using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class EntityNotFoundException : BaseException
{
    public EntityNotFoundException(string message) : base(message)
    {
    }
}
