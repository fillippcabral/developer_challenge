using Infraestrutura.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public class ConextoDoBancoDeDados : DbContext
    {
        public const string Schema = "DevelopChallenge";

        public ConextoDoBancoDeDados() : base(GetOptions(ConstantesDeBancoDeDados.ConexaoLocal)) { }

        public ConextoDoBancoDeDados(string connectionString) : base(GetOptions(connectionString)) { }

        public ConextoDoBancoDeDados(DbContextOptions<ConextoDoBancoDeDados> options) : base(options) { }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

        }

        public DbSet<EntidadeClimaAeroporto> ClimaAeroporto { get; set; }
        public DbSet<EntidadeClimaCidade> ClimaCidade { get; set; }
        public DbSet<EntidadeClima> Clima { get; set; }
        public DbSet<EntidadeLogErro> LogErro { get; set; }

    }
}
