﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Api.Entities;
using RocketseatAuction.Api.Repositories;

namespace RocketseatAuction.Api.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketseatAuctionDbContext();

        var today = new DateTime(2024, 01, 20);

        return repository
            .Auctions
            .Include(auction => auction.Items)            
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}