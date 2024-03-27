using Dominio.Comandos.Aeroporto;
using Dominio.Comandos.Cidade;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Dominio
{
    public static class InjecaoDeDependencias
    {
        public static void AdicionarDependenciasDoDominio(this IServiceCollection services)
        {
            services.CarregarAssembliesMediatR(typeof(ComandoObterClimaAeroporto).Assembly);
            services.CarregarAssembliesMediatR(typeof(ComandoObterClimaCidade).Assembly);

        }
    }
}
