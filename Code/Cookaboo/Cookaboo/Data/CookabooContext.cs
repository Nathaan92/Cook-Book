using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookaboo.Models;
using Microsoft.EntityFrameworkCore;

namespace Cookaboo.Data
{
    public class CookabooContext : DbContext

    {
        public CookabooContext (DbContextOptions<CookabooContext> options) : base(options)
        {
        }

        public DbSet<Recipes> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipes>().ToTable("Recipe");
        }
    }
}
