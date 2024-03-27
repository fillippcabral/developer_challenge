using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Consultas
{
    public interface IConsultaDoDominio : INotification { }
    public interface IConsultaDoDominio<RetornoT> : IRequest<RetornoT> where RetornoT : IRetornoDeConsulta { }
}
