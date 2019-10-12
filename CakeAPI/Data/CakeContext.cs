using CakeAPI.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeAPI.Data
{
    public class CakeContext : DbContext
    {
        public CakeContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cake> Cakes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>(Configure);
        }

        private void Configure(EntityTypeBuilder<Cake> builder)
        {
            builder.ToTable("Cakes");
            builder.Property(c => c.Id)
                .IsRequired()
                .ForSqlServerUseSequenceHiLo("cakes_hilo");
        }
    }
}
