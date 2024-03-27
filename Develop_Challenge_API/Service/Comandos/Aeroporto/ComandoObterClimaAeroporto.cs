using Core.Dominio.Comandos;
using Dominio.Respostas.Aeroporto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comandos.Aeroporto
{
    public class ComandoObterClimaAeroporto : IComandoDoDominio<RespostaAeroporto>
    {
        public string CodigoIcao { get; set; }
    }
}
