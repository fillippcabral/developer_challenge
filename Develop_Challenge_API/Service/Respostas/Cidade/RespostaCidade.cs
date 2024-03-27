using Core.Dominio.Comandos;
using Dominio.Externo.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio.Respostas.Cidade
{
    public class RespostaCidade : IRetornoDoComando
    {
        public RespostaCidade() { }

        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public List<ClimaDto> Clima { get; set; }
    }
}
