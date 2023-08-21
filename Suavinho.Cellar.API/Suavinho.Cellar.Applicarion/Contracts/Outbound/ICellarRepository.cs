using  CellarEntity = Suavinho.Cellar.Domain.Entity.Cellar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Application.Contracts.Outbound
{
    public interface ICellarRepository
    {
        IEnumerable<CellarEntity> GetAll();
        CellarEntity GetCellar(int cellarId);
        void CreateCellar(CellarEntity cellar);
        void UpdateCellar(CellarEntity cellar);
        void DeleteCellar(int cellarId);
    }
}
