using Suavinho.Cellar.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Applicarion.Contracts.Inbound
{
    public interface IWineService
    {
        IEnumerable<WineDTO> GetAll(int cellarId);
        WineDTO GetWine(int cellarId, int wineId);
        void CreateWine(WineDTO wineDto, int cellarId);
        void UpdateWine(WineDTO wineDto, int cellarId, int wineId);
        void DeleteCellar(bool isDeleteAll, int cellarId, int wineId);
    }
}
