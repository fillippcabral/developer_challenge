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
    public class ArmazenadorLogErro : IArmazenadorLogErro
    {

        private readonly ConextoDoBancoDeDados _context;
        private readonly IMediadorDoDominio _mediador;

        public ArmazenadorLogErro(ConextoDoBancoDeDados context, IMediadorDoDominio mediador)
        {
            _context = context;
            _mediador = mediador;
        }

        public void LogErro(string conteudo, string mensagem, string tipoLog)
        {
            var log = new EntidadeLogErro()
            {
                Id = Guid.NewGuid(),
                Conteudo = conteudo,
                MensagemErro = mensagem,
                TipoLog = tipoLog
            };

            _context.AdicionarESalvar(log);
        }
    }
}
