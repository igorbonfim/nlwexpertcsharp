using RocketseatAuction.Api.Entities;

namespace RocketseatAuction.Api.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
