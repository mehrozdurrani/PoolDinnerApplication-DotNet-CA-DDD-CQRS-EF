using PoolDinner.Domain.UserAggregate;
namespace PoolDinner.Application.Services.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token
    );
}