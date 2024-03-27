using Core.Dominio.Consultas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Mediador.ImplementacoesMediatR
{
    internal class ConsultasComMediatR : IConsultasDoDominio
    {
        private readonly IMediator _mediator;

        public ConsultasComMediatR(IMediator mediator)
        {
            _mediator = mediator;

        }

        public async Task<RetornoT> Enviar<RetornoT>(IConsultaDoDominio<RetornoT> comando) where RetornoT : IRetornoDeConsulta
        {
            try { return await _mediator.Send(comando); } //Tratamento de Injeção de dependências em testes
            catch (InvalidOperationException) { return default; }

        }

        public async Task Enviar(IConsultaDoDominio comando)
        {
            try { await _mediator.Publish(comando); }//Tratamento de Injeção de dependências em testes
            catch (InvalidOperationException) { }

        }

    }
}
