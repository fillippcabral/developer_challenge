using Core.Dominio.Comandos;
using Dominio.Respostas.Cidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comandos.Cidade
{
    public class ComandoObterClimaCidade : IComandoDoDominio<RespostaCidade>
    {
        public string CodigoCidade { get; set; }
    }
}
