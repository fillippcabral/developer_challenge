using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Comandos
{
    public abstract class ManipuladorDoComandoAsync<ComandoT, RetornoT> : IRequestHandler<ComandoT, RetornoT> where RetornoT : IRetornoDoComando where ComandoT : IComandoDoDominio<RetornoT>
    {
        public async Task<RetornoT> Handle(ComandoT comando, CancellationToken cancellationToken)
        {
            return await Manipular(comando);

        }

        public abstract Task<RetornoT> Manipular(ComandoT comando);

    }

    public abstract class ManipuladorDoComando<ComandoT, RetornoT> : IRequestHandler<ComandoT, RetornoT> where RetornoT : IRetornoDoComando where ComandoT : IComandoDoDominio<RetornoT>
    {
        public async Task<RetornoT> Handle(ComandoT comando, CancellationToken cancellationToken)
        {
            return Manipular(comando);

        }

        public abstract RetornoT Manipular(ComandoT comando);

    }

    public abstract class ManipuladorDoComandoAsync<ComandoT> : INotificationHandler<ComandoT> where ComandoT : IComandoDoDominio
    {
        public async Task Handle(ComandoT comando, CancellationToken cancellationToken)
        {
            await Manipular(comando);

        }

        public abstract Task Manipular(ComandoT comando);

    }

    public abstract class ManipuladorDoComando<ComandoT> : INotificationHandler<ComandoT> where ComandoT : IComandoDoDominio
    {
        public async Task Handle(ComandoT comando, CancellationToken cancellationToken)
        {
            Manipular(comando);

        }

        public abstract void Manipular(ComandoT comando);

    }
}
