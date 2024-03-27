using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Eventos
{
    public abstract class ManipuladorDoEventoAsync<Evento> : INotificationHandler<Evento> where Evento : IEventoDoDominio
    {
        public async Task Handle(Evento evento, CancellationToken cancellationToken)
        {
            await Manipular(evento);

        }

        public abstract Task Manipular(Evento evento);

    }
}
