using RocketseatAuction.Api.Communication.Requests;
using RocketseatAuction.Api.Entities;
using RocketseatAuction.Api.Repositories;
using RocketseatAuction.Api.Services;

namespace RocketseatAuction.Api.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;

    public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;
    public int Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new RocketseatAuctionDbContext();

        var user = _loggedUser.User();

        var offer = new Offer
        {            
            CreatedOn = DateTime.UtcNow,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };

        repository.Offers.Add(offer);

        repository.SaveChanges();

        return offer.Id;
    }
}
