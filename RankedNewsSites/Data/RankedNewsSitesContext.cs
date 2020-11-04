using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RankedNewsSites.Models;

namespace RankedNewsSites.Data
{
    public class RankedNewsSitesContext : DbContext
    {
        public RankedNewsSitesContext (DbContextOptions<RankedNewsSitesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSite>().HasKey(x => new { x.UserId, x.SiteId });
        }

        public DbSet<RankedNewsSites.Models.NewsSite> NewsSite { get; set; }
        public DbSet<UserSite> UserSite { get; set; }
    }
}
