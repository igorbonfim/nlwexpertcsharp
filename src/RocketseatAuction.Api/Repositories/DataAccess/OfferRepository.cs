using RocketseatAuction.Api.Contracts;
using RocketseatAuction.Api.Entities;

namespace RocketseatAuction.Api.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;
    public OfferRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;
    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
