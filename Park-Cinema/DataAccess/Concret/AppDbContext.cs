using Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concret
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Navbar> Navbars { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Laser> Lasers { get; set; }
        public DbSet<Rules> Rules { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionPrice> SessionPrices { get; set; }
        public DbSet<VIP> VIPs { get; set; }
        public DbSet<AdvertisingOffer> AdvertisingOffers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketSeat> TicketSeats { get; set; }
        public DbSet<MovieContentLanguage> MovieContentLanguages { get; set; }
        public DbSet<BranchLanguage> BranchLanguages { get; set; }
    }
}