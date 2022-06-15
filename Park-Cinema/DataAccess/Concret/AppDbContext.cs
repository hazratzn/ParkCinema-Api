using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Navbar> Navbars { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieDetail> MovieDetails { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Laser> Lasers { get; set; }
        public DbSet<Rules> Rules { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<VIP> VIPs { get; set; }
        public DbSet<AdvertisingOffer> AdvertisingOffers { get; set; }
        public DbSet<MovieFormat> MovieFormats { get; set; }
        public DbSet<Language> Languages { get; set; }

        #region Required
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Movie>()
        //       .HasOne(m => m.MovieDetail)
        //       .WithOne(m => m.Movie)
        //       .OnDelete(DeleteBehavior.NoAction);

        //    modelBuilder.Entity<MovieDetail>()
        //        .HasOne(m => m.Movie)
        //        .WithOne(m => m.MovieDetail)
        //        .OnDelete(DeleteBehavior.NoAction);

        //}
        #endregion
    }
}
