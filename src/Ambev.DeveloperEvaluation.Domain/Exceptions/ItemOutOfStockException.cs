using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class ItemOutOfStockException : BaseException
{
    public ItemOutOfStockException(string message) : base(message)
    {
    }
}
