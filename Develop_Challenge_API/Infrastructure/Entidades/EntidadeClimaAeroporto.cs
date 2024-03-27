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
    [Table(nameof(ConextoDoBancoDeDados.ClimaAeroporto), Schema = ConextoDoBancoDeDados.Schema)]
    public class EntidadeClimaAeroporto : EntidadeDoBancoDeDados
    {
        [Key]
        public override Guid Id { get; set; }
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
