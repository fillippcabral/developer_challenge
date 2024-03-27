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
    public class ArmazenadorDeClimaAeroporto : IArmazenadorClimaAeroporto
    {

        private readonly ConextoDoBancoDeDados _context;
        private readonly IMediadorDoDominio _mediador;

        public ArmazenadorDeClimaAeroporto(ConextoDoBancoDeDados context, IMediadorDoDominio mediador)
        {
            _context = context;
            _mediador = mediador;
        }

        public void SalvarClimaAeroporto(int umidade, string visibilidade, string codigoIcao, int pressaoAtmosferica, int vento, int direcaoVento, string condicao, string condicaoDesc, int temp, DateTime atualizadoEm)
        {
            if (String.IsNullOrEmpty(codigoIcao))
            {
                _mediador.Notificacoes.Adicionar("Clima do Aeroporto incorreto");
            }

            var climaAeroporto = new EntidadeClimaAeroporto()
            {
                AtualizadoEm = atualizadoEm,
                CodigoIcao = codigoIcao,
                Condicao = condicao,
                CondicaoDesc = condicaoDesc,
                Temp = temp,
                DirecaoVento = direcaoVento,
                PressaoAtmosferica = pressaoAtmosferica,
                Id = Guid.NewGuid(),
                Umidade = umidade,
                Vento = vento,
                Visibilidade = visibilidade
            };

            _context.AdicionarESalvar(climaAeroporto);
        }
    }
}
