using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Externo.DTOs
{
    [DataContract]
    public class ClimaDto
    {
        [DataMember(Name = "data")]
        public DateTime Data { get; set; }
        [DataMember(Name = "condicao")]
        public string Condicao { get; set; }
        [DataMember(Name = "condicao_desc")]
        public string CondicaoDesc { get; set; }
        [DataMember(Name = "min")]
        public int Min { get; set; }
        [DataMember(Name = "max")]
        public int Max { get; set; }
        [DataMember(Name = "indice_uv")]
        public int IndiceUv { get; set; }
    }
}
