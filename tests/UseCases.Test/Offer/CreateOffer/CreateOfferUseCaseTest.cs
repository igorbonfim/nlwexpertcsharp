using Bogus;
using FluentAssertions;
using Moq;
using RocketseatAuction.Api.Communication.Requests;
using RocketseatAuction.Api.Contracts;
using RocketseatAuction.Api.Entities;
using RocketseatAuction.Api.Enums;
using RocketseatAuction.Api.Services;
using RocketseatAuction.Api.UseCases.Offers.CreateOffer;
using Xunit;

namespace UseCases.Test.Auctions.GetCurrent;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Success(int itemId)
    {
        //ARRANGE 
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 1000)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());

        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        //ACT
        var act = () => useCase.Execute(itemId, request);

        //ASSERT      
        act.Should().NotThrow();
    }
}
