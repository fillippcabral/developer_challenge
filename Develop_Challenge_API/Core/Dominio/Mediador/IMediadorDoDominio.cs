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
    public interface IMediadorDoDominio
    {
        INotificacoesDoDominio Notificacoes { get; }
        IComandosDoDominio Comandos { get; }
        IConsultasDoDominio Consultas { get; }
        IEventosDoDominio Eventos { get; }

    }
}
