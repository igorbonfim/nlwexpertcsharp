using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Api.Entities;

namespace RocketseatAuction.Api.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public RocketseatAuctionDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }    
}
