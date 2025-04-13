using Ambev.DeveloperEvaluation.Domain.Base;

namespace Ambev.DeveloperEvaluation.Domain.Interfaces.Intergrations;

public interface IRabbitMQIntegration
{
    public Task PublishMessageAsync(BaseEvent @event);
}
