using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Comandos
{
    public interface IComandosDoDominio
    {
        Task<RetornoT> Enviar<RetornoT>(IComandoDoDominio<RetornoT> comando) where RetornoT : IRetornoDoComando;
        Task Enviar(IComandoDoDominio comando);

    }
}
