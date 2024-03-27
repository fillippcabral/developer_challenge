using Core.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio.Respostas.Aeroporto
{
    public class RespostaAeroporto : IRetornoDoComando
    {
        public RespostaAeroporto() { }

        public int Umidade { get; set; }
        public string Visibilidade { get; set; }
        public string CodigoIcao { get; set; }
        public int PressaoAtmosferica { get; set; }
        public int Vento { get; set; }
        public int DirecaoVento { get; set; }
        public string Condicao { get; set; }
        public string CondicaoDesc { get; set; }
        public int Temp { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
