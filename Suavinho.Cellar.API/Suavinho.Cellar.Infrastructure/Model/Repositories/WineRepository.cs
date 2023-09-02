using Microsoft.EntityFrameworkCore;
using Suavinho.Cellar.Application.Contracts.Outbound;
using Suavinho.Cellar.Domain.Entity;
using Suavinho.Cellar.Infrastructure.Model.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Infrastructure.Model.Repositories
{
    public class WineRepository : IWineRepository
    {
        public CellarDataContext _cellarDataContext{ get; }

        public WineRepository(CellarDataContext cellarDataContext)
        {
            _cellarDataContext = cellarDataContext;
        }

        public IEnumerable<Wine> GetAll(int cellarId)
        {
            var cellarWines = _cellarDataContext.CellarWines.Where(cw => cw.CellarId == cellarId);
            var wines = cellarWines.Select(cw => cw.Wine);
            return wines;
        }

        public Wine GetWine(int cellarId, int wineId)
        {
            var cellarWines = _cellarDataContext.CellarWines.Where(cw => cw.CellarId == cellarId);
            var wine = cellarWines.FirstOrDefault(cw => cw.WineId == wineId).Wine;
            return wine;
        }

        public void CreateWine(Wine wine, int cellarId)
        {
            var cellar = _cellarDataContext.Cellars.FirstOrDefault(c => c.Id == cellarId);
            
            var cellarWine = new CellarWine
            {
                CellarId = cellarId,
                Cellar = cellar,
                Wine = wine
            };
            
            _cellarDataContext.CellarWines.Add(cellarWine);
            _cellarDataContext.SaveChanges();
        }

        public void UpdateWine(Wine wine, int cellarId, int wineId)
        {
            var cellar = _cellarDataContext.Cellars.FirstOrDefault(c => c.Id == cellarId);

            var cellarWine = new CellarWine
            {
                CellarId = cellarId,
                Cellar = cellar,
                WineId = wineId,
                Wine = wine
            };

            _cellarDataContext.CellarWines.Update(cellarWine);
            _cellarDataContext.SaveChanges();
        }

        public void DeleteWine(bool isDeleteAll, int cellarId, int wineId)
        {
            var cellarWine = _cellarDataContext.CellarWines
                .Include(cw => cw.Wine)
                .FirstOrDefault(cw => cw.CellarId == cellarId && cw.WineId == wineId);

            if (isDeleteAll || cellarWine.Wine.Quantity == 1)
                _cellarDataContext.Wines.Remove(cellarWine.Wine);
            else
                cellarWine.Wine.Quantity--;   

            _cellarDataContext.SaveChanges();
        }
    }
}
