using RocketseatAuction.Api.Communication.Requests;
using RocketseatAuction.Api.Contracts;
using RocketseatAuction.Api.Entities;
using RocketseatAuction.Api.Repositories;
using RocketseatAuction.Api.Services;

namespace RocketseatAuction.Api.UseCases.Offers.CreateOffer;

public class CreateOfferUseCase
{
    private readonly ILoggedUser _loggedUser;
    private readonly IOfferRepository _repository;

    public CreateOfferUseCase(ILoggedUser loggedUser, IOfferRepository repository)
    {
        _loggedUser = loggedUser;
        _repository = repository;
    }
    public int Execute(int itemId, RequestCreateOfferJson request)
    {     
        var user = _loggedUser.User();

        var offer = new Offer
        {            
            CreatedOn = DateTime.UtcNow,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };        

        _repository.Add(offer);

        return offer.Id;
    }
}
