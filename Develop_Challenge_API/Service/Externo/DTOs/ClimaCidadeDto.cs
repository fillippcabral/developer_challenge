using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Externo.DTOs
{
    [DataContract]
    public class ClimaCidadeDto
    {
        [DataMember(Name = "cidade")]
        public string Cidade { get; set; }
        [DataMember(Name = "estado")]
        public string Estado { get; set; }
        [DataMember(Name = "atualizado_em")]
        public DateTime AtualizadoEm { get; set; }
        [DataMember(Name = "clima")]
        public List<ClimaDto> Clima { get; set; }
    }
}
