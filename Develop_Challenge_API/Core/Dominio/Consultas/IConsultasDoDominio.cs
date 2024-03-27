using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Consultas
{
    public interface IConsultasDoDominio
    {
        Task<RetornoT> Enviar<RetornoT>(IConsultaDoDominio<RetornoT> comando) where RetornoT : IRetornoDeConsulta;
        Task Enviar(IConsultaDoDominio comando);

    }
}
