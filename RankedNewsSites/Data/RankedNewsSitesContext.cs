using System;
using System.Collections.Generic;
using System.Linq;
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

        public DbSet<RankedNewsSites.Models.NewsSite> NewsSite { get; set; }
    }
}
