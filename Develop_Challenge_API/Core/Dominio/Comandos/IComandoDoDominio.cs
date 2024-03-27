using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Comandos
{
    public interface IComandoDoDominio : INotification { }
    public interface IComandoDoDominio<RetornoT> : IRequest<RetornoT> where RetornoT : IRetornoDoComando { }
}
