using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorios.Interfaces
{
    public interface IArmazenadorLogErro
    {
        void LogErro(string conteudo, string mensagem, string tipoLog);
    }
}
