using Core.Dominio.Comandos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Mediador.ImplementacoesMediatR
{
    internal class ComandosComMediatR : IComandosDoDominio
    {
        private readonly IMediator _mediator;

        public ComandosComMediatR(IMediator mediator)
        {
            _mediator = mediator;

        }

        public async Task<RetornoT> Enviar<RetornoT>(IComandoDoDominio<RetornoT> comando) where RetornoT : IRetornoDoComando
        {
            try { return (RetornoT)await _mediator.Send(comando); } //Tratamento de Injeção de dependências em testes
            catch (InvalidOperationException) { return default; }

        }

        public async Task Enviar(IComandoDoDominio comando)
        {
            try { await _mediator.Publish(comando); }//Tratamento de Injeção de dependências em testes
            catch (InvalidOperationException) { }

        }

    }
}
