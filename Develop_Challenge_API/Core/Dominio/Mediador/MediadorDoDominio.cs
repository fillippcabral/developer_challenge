using Core.Dominio.Comandos;
using Core.Dominio.Consultas;
using Core.Dominio.Eventos;
using Core.Dominio.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Mediador
{
    public class MediadorDoDominio : IMediadorDoDominio
    {
        private readonly INotificacoesDoDominio _notificacoes;
        private readonly IComandosDoDominio _comandos;
        private readonly IConsultasDoDominio _consultas;
        private readonly IEventosDoDominio _eventos;

        public MediadorDoDominio(INotificacoesDoDominio notificacoes, IComandosDoDominio comandos, IConsultasDoDominio consultas, IEventosDoDominio eventos)
        {
            _notificacoes = notificacoes;
            _comandos = comandos;
            _consultas = consultas;
            _eventos = eventos;

        }

        public INotificacoesDoDominio Notificacoes => _notificacoes;
        public IComandosDoDominio Comandos => _comandos;
        public IConsultasDoDominio Consultas => _consultas;
        public IEventosDoDominio Eventos => _eventos;

    }
}
