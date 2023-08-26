using Suavinho.Cellar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Application.Contracts.Outbound
{
    public interface IWineRepository
    {
        IEnumerable<Wine> GetAll(int cellarId);
        Wine GetWine(int cellarId, int wineId);
        void CreateWine(Wine wine, int cellarId);
        void UpdateWine(Wine wine, int cellarId, int wineId);
        void DeleteWine(bool isDeleteAll, int cellarId, int wineId);
    }
}
