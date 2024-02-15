using RocketseatAuction.Api.Entities;

namespace RocketseatAuction.Api.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
