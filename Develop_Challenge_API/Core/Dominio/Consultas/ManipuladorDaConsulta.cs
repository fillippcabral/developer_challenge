using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Consultas
{
    public abstract class ManipuladorDaConsultaAsync<ConsultaT, RetornoT> : IRequestHandler<ConsultaT, RetornoT> where RetornoT : IRetornoDeConsulta where ConsultaT : IConsultaDoDominio<RetornoT>
    {
        public async Task<RetornoT> Handle(ConsultaT comando, CancellationToken cancellationToken)
        {
            return await Manipular(comando);

        }

        public abstract Task<RetornoT> Manipular(ConsultaT comando);

    }

    public abstract class ManipuladorDaConsulta<ConsultaT, RetornoT> : IRequestHandler<ConsultaT, RetornoT> where RetornoT : IRetornoDeConsulta where ConsultaT : IConsultaDoDominio<RetornoT>
    {
        public async Task<RetornoT> Handle(ConsultaT comando, CancellationToken cancellationToken)
        {
            return Manipular(comando);

        }

        public abstract RetornoT Manipular(ConsultaT comando);

    }

    public abstract class ManipuladorDaConsultaAsync<ConsultaT> : INotificationHandler<ConsultaT> where ConsultaT : IConsultaDoDominio
    {
        public async Task Handle(ConsultaT comando, CancellationToken cancellationToken)
        {
            await Manipular(comando);

        }

        public abstract Task Manipular(ConsultaT comando);

    }

    public abstract class ManipuladorDaConsulta<ConsultaT> : INotificationHandler<ConsultaT> where ConsultaT : IConsultaDoDominio
    {
        public async Task Handle(ConsultaT comando, CancellationToken cancellationToken)
        {
            Manipular(comando);

        }

        public abstract void Manipular(ConsultaT comando);

    }
}
