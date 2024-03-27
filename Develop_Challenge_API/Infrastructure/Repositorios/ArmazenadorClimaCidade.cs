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
    public class ArmazenadorClimaCidade : IArmazenadorClimaCidade
    {
        private readonly ConextoDoBancoDeDados _context;
        private readonly IMediadorDoDominio _mediador;

        public ArmazenadorClimaCidade(ConextoDoBancoDeDados context, IMediadorDoDominio mediador)
        {
            _context = context;
            _mediador = mediador;
        }

        public Guid SalvarClimaCidade(string cidade, string estado, DateTime atualizadoEm)
        {
            if (String.IsNullOrEmpty(cidade))
            {
                _mediador.Notificacoes.Adicionar("Cidade incorreta");
            }

            var climaCidade = new EntidadeClimaCidade()
            {
                Id = Guid.NewGuid(),
                AtualizadoEm = atualizadoEm,
                Cidade = cidade,
                Estado = estado
            };

            _context.AdicionarESalvar(climaCidade);

            return climaCidade.Id;
        }
    }
}
