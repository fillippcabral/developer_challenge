using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Notificacoes
{
    public interface INotificacoesDoDominio
    {
        bool ContemNotificacao { get; }
        bool FoiInterrompido { get; }
        bool SemInterrupcoes { get; }
        INotificacaoDoDominio[] Listar { get; }
        void Adicionar(string mensagem, bool exibirParaUsuario = true, bool provocaInterrupcao = true);

    }
}
