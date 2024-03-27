using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorios.Interfaces
{
    public interface IArmazenadorClimaAeroporto
    {
        void SalvarClimaAeroporto(int umidade, string visibilidade, string codigoIcao, int pressaoAtmosferica, int vento, int direcaoVento, string condicao, string condicaoDesc, int temp, DateTime atualizadoEm);
    }
}
