using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.Api.Communication.Requests;
using RocketseatAuction.Api.Filters;
using RocketseatAuction.Api.UseCases.Offers.CreateOffer;

namespace RocketseatAuction.Api.Controllers;

[ServiceFilter(typeof(AutheticationUserAttribute))]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId, 
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
