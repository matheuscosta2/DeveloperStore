using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class RabbitMQMessageException : BaseException
{
    public RabbitMQMessageException(string message) : base(message)
    {
    }

    public RabbitMQMessageException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
