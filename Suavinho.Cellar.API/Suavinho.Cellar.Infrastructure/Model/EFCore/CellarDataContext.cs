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
            optionsBuilder.UseNpgsql("Host=localhost; Database=db_cellar; Username=postgres; Password=senha-forte-kkkk!");
            //optionsBuilder.UseNpgsql("Host=172.17.0.3; Database=db_cellar; Username=postgres; Password=senha-forte-kkkk!");
        }

        public DbSet<CellarEntity> Cellars { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<CellarWine> CellarWines { get; set; }
    }
}
