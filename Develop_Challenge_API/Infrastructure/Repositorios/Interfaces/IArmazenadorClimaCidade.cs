using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorios.Interfaces
{
    public interface IArmazenadorClimaCidade
    {
        Guid SalvarClimaCidade(string cidade, string estado, DateTime atualizadoEm);
    }
}
