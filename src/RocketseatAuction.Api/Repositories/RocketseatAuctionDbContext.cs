using Microsoft.EntityFrameworkCore;
using RocketseatAuction.Api.Entities;

namespace RocketseatAuction.Api.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Projetos\RockseatAuction\leilaoDbNLW.db");
    }
}
