using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class RabbitMQConnectionException : BaseException
{
    public RabbitMQConnectionException(string message) : base(message)
    {
    }
}
