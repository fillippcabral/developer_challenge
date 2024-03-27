using Core.Dominio.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AspNetCoreWebApi
{
    public class RetornoPadraoDaApi<T> where T : new()
    {
        public bool Sucedido { get; set; } = true;
        public INotificacaoDoDominio[] Notificacoes { get; set; } = Array.Empty<INotificacaoDoDominio>();
        public T? Resposta { get; set; }

    }

    public class RetornoPadraoDaApi
    {
        public bool Sucedido { get; set; } = true;
        public INotificacaoDoDominio[] Notificacoes { get; set; } = Array.Empty<INotificacaoDoDominio>();

    }
}
