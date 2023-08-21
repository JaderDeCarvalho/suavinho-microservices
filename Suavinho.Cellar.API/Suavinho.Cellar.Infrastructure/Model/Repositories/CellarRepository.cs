using Suavinho.Cellar.Application.Contracts.Outbound;
using Suavinho.Cellar.Infrastructure.Model.EFCore;
using CellarEntity = Suavinho.Cellar.Domain.Entity.Cellar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Infrastructure.Model.Repositories
{
    public class CellarRepository : ICellarRepository
    {
        private CellarDataContext _cellarDataContext { get; }

        public CellarRepository(CellarDataContext cellarDataContext)
        {
            _cellarDataContext = cellarDataContext;
        }

        public void CreateCellar(CellarEntity cellar)
        {
            _cellarDataContext.Add(cellar);
            _cellarDataContext.SaveChanges();
        }

        public IEnumerable<CellarEntity> GetAll()
        {
            return _cellarDataContext.Cellars;
        }

        public CellarEntity GetCellar(int cellarId)
        {
            return _cellarDataContext.Cellars.FirstOrDefault(c => c.Id == cellarId);
        }

        public void UpdateCellar(CellarEntity cellar)
        {
            _cellarDataContext.Update(cellar);
            _cellarDataContext.SaveChanges();
        }

        public void DeleteCellar(int cellarId)
        {
            var cellar = _cellarDataContext.Cellars.FirstOrDefault(x => x.Id == cellarId);
            _cellarDataContext.Cellars.Remove(cellar);
            _cellarDataContext.SaveChanges();
        }
    }
}
