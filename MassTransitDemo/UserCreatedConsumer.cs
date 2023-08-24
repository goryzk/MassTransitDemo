using Contracts;
using MassTransit;

namespace MassTransitDemo;

public class UserCreatedConsumer : IConsumer<UserCreated>
{
    private readonly ILogger<UserCreatedConsumer> _logger;

    public UserCreatedConsumer(ILogger<UserCreatedConsumer> logger)
    {
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<UserCreated> context)
    {
        await Task.CompletedTask;
        _logger.LogInformation("Message with name {Name} and city {City} Was consumed", context.Message.Name, context.Message.City);
    }
}