using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dominio.Eventos
{
    public interface IEventosDoDominio
    {
        Task Publicar(IEventoDoDominio evento);

    }
}
