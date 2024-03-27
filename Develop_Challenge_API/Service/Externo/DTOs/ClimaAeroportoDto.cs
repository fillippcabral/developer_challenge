using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Externo.DTOs
{
    [DataContract]
    public class ClimaAeroportoDto
    {
        [DataMember(Name = "umidade")]
        public int Umidade { get; set; }
        [DataMember(Name = "visibilidade")]
        public string Visibilidade { get; set; }
        [DataMember(Name = "codigo_icao")]
        public string CodigoIcao { get; set; }
        [DataMember(Name = "pressao_atmosferica")]
        public int PressaoAtmosferica { get; set; }
        [DataMember(Name = "vento")]
        public int Vento { get; set; }
        [DataMember(Name = "direcao_vento")]
        public int DirecaoVento { get; set; }
        [DataMember(Name = "condicao")]
        public string Condicao { get; set; }
        [DataMember(Name = "condicao_desc")]
        public string CondicaoDesc { get; set; }
        [DataMember(Name = "temp")]
        public int Temp { get; set; }
        [DataMember(Name = "atualizado_em")]
        public DateTime AtualizadoEm { get; set; }
    }
}
