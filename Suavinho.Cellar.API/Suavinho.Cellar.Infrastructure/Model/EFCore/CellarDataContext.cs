using Microsoft.EntityFrameworkCore;
using Suavinho.Cellar.Domain.Entity;
using CellarEntity = Suavinho.Cellar.Domain.Entity.Cellar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Infrastructure.Model.EFCore
{
    public class CellarDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=db_cellar; Username=postgres; Password=strongPassword");
            //optionsBuilder.UseNpgsql("Host=172.17.0.3; Database=db_cellar; Username=postgres; Password=strongPassword");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CellarWine>() // composite primary key
                .HasKey(p => new { p.CellarId, p.WineId });
            modelBuilder.Entity<CellarWine>()
                        .HasOne(a => a.Cellar)
                        .WithMany(c => c.CellarWine)
                        .HasForeignKey(fk => fk.CellarId);
            modelBuilder.Entity<CellarWine>()
                        .HasOne(a => a.Wine)
                        .WithMany(c => c.CellarWine)
                        .HasForeignKey(fk => fk.WineId);
        }

        public DbSet<CellarEntity> Cellars { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<CellarWine> CellarWines { get; set; }
    }
}
