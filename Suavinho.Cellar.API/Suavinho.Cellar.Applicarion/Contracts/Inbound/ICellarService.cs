using Suavinho.Cellar.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suavinho.Cellar.Application.Contracts.Inbound
{
    public interface ICellarService
    {
        IEnumerable<CellarDTO> GetAll();
        CellarDTO GetCellar(int cellarId);
        void CreateCellar(CellarDTO cellarDto);
        void UpdateCellar(CellarDTO cellarDto);
        void DeleteCellar(int cellarId);
    }
}
