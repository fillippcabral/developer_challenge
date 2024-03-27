using Core.BancoDeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Entidades
{
    [Table(nameof(ConextoDoBancoDeDados.Clima), Schema = ConextoDoBancoDeDados.Schema)]
    public class EntidadeClima : EntidadeDoBancoDeDados
    {
        [Key]
        public override Guid Id { get; set; }
        public Guid EntidadeClimaCidadeId { get; set; }
        public DateTime Data { get; set; }
        public string Condicao { get; set; }
        public string CondicaoDesc { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int IndiceUv {get; set;}
    }
}
