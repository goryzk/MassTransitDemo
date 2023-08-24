using Contracts;
using MassTransit.Web.Models;

namespace MassTransit.Web.Services;

public class UserService : IUserService
{
    private readonly IBus _bus;

    public UserService(IBus bus)
    {
        _bus = bus;
    }

    public async Task CreateUser(User user, CancellationToken token)
    {
        // Some operation here (Save User In real DB).
        
        await _bus.Publish(new UserCreated(user.Name, user.City), token); // Publish message in to queue.
    }
}