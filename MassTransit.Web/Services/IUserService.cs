using MassTransit.Web.Models;

namespace MassTransit.Web.Services;

public interface IUserService
{
    Task CreateUser(User user, CancellationToken token);
}