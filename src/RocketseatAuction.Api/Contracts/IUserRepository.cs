using RocketseatAuction.Api.Entities;

namespace RocketseatAuction.Api.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);

    User GetUserByEmail(string email);
}
