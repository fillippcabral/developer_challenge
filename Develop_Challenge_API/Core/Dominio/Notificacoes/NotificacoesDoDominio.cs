using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Notificacoes
{
    internal class NotificacoesDoDominio : INotificacoesDoDominio
    {
        private List<Notificacao> _notificacoes { get; set; } = new();
        public bool ContemNotificacao => _notificacoes.Any();
        public bool FoiInterrompido => _notificacoes.Any(x => x.ProvocaInterrupcao);
        public bool SemInterrupcoes => !FoiInterrompido;
        public INotificacaoDoDominio[] Listar => _notificacoes.ToArray();

        public void Adicionar(string mensagem, bool exibirParaUsuario, bool provocaInterrupcao)
        {
            _notificacoes.Add(new(mensagem, exibirParaUsuario, provocaInterrupcao));

        }

        public class Notificacao : INotificacaoDoDominio
        {
            public Notificacao(string mensagem, bool podeExibirParaUsuario, bool provocaInterrupcao)
            {
                Mensagem = mensagem;
                PodeExibirParaUsuario = podeExibirParaUsuario;
                ProvocaInterrupcao = provocaInterrupcao;

            }

            public string Mensagem { get; private set; }
            public bool PodeExibirParaUsuario { get; private set; }
            public bool ProvocaInterrupcao { get; private set; }

        }


    }
}
