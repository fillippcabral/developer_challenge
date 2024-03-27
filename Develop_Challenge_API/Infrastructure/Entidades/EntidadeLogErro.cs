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
    [Table(nameof(ConextoDoBancoDeDados.LogErro), Schema = ConextoDoBancoDeDados.Schema)]
    public class EntidadeLogErro : EntidadeDoBancoDeDados
    {
        [Key]
        public override Guid Id { get; set; }
        public string TipoLog { get; set; }
        public string Conteudo { get; set; }
        public string MensagemErro { get; set; }
    }
}
