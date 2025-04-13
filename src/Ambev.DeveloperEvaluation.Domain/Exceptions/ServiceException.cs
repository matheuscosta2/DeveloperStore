using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Exceptions;

public class ServiceException : BaseException
{
    public ServiceException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
