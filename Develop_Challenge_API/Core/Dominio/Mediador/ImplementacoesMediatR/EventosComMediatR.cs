using Core.Dominio.Eventos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Mediador.ImplementacoesMediatR
{
    internal class EventosComMediatR : IEventosDoDominio
    {
        private readonly IMediator _mediator;

        public EventosComMediatR(IMediator mediator)
        {
            _mediator = mediator;

        }

        public async Task Publicar(IEventoDoDominio evento)
        {
            try { await _mediator.Publish(evento); } //Tratamento de Injeção de dependências em testes
            catch (InvalidOperationException) { }

        }

    }
}
