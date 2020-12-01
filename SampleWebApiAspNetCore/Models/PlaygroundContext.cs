using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SampleWebApiAspNetCore.Models
{
    public class PlaygroundContext : DbContext
    {
        public PlaygroundContext(DbContextOptions<PlaygroundContext> options) : base(options)
        {
        }

        public DbSet<Playground> playground { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
