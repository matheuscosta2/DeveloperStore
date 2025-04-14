using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class ItemQuantityLimitExceededException : BaseException
{
    public ItemQuantityLimitExceededException(string message) : base(message)
    {
    }
}
