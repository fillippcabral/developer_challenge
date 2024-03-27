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
    [Table(nameof(ConextoDoBancoDeDados.ClimaCidade), Schema = ConextoDoBancoDeDados.Schema)]
    public class EntidadeClimaCidade : EntidadeDoBancoDeDados
    {
        [Key]
        public override Guid Id { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
