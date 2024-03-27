using Core.BancoDeDados;
using Core.Dominio.Mediador;
using Infraestrutura.Entidades;
using Infraestrutura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorios
{
    internal class ArmazenadorClima : IArmazenadorClima
    {
        private readonly ConextoDoBancoDeDados _context;
        private readonly IMediadorDoDominio _mediador;

        public ArmazenadorClima(ConextoDoBancoDeDados context, IMediadorDoDominio mediador)
        {
            _context = context;
            _mediador = mediador;
        }

        public void SalvarClima(Guid ClimaCidadeId, DateTime data, string condicao, string condicaoDesc, int min, int max, int indiceUv)
        {
            if(ClimaCidadeId == Guid.Empty)
            {
                _mediador.Notificacoes.Adicionar("Clima incorreto");
            }

            var clima = new EntidadeClima()
            {
                Id = Guid.NewGuid(),
                EntidadeClimaCidadeId = ClimaCidadeId,
                Data = data,
                Condicao = condicao,
                CondicaoDesc = condicaoDesc,
                Min = min,
                Max = max,
                IndiceUv = indiceUv
            };

            _context.AdicionarESalvar(clima);
        }
    }
}
