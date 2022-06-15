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
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
