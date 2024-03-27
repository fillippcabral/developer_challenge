using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorios.Interfaces
{
    public interface IArmazenadorClima
    {
        void SalvarClima(Guid ClimaCidadeId, DateTime data, string condicao, string condicaoDesc, int min, int max, int indiceUv);
    }
}
