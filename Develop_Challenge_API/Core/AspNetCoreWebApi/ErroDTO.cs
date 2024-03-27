using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AspNetCoreWebApi
{
    public class ErroDTO
    {
        public ErroDTO(string mensagem, Exception? ex = null)
        {
            Excecao = ex;
            Mensagem = mensagem;

        }

        public Guid Id { get; private set; } = Guid.NewGuid();
        public Exception? Excecao { get; private set; }
        public string Mensagem { get; private set; }


    }
}
