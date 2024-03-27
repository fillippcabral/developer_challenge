using Infraestrutura.Repositorios;
using Infraestrutura.Repositorios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public static class InjecaoDeDependencias
    {
        public static void AdicionarDependenciasDeBancoDeDados(this IServiceCollection services)
        {
            services.AddScoped<IArmazenadorClima, ArmazenadorClima>();
            services.AddScoped<IArmazenadorClimaAeroporto, ArmazenadorDeClimaAeroporto>();
            services.AddScoped<IArmazenadorClimaCidade, ArmazenadorClimaCidade>();
            services.AddScoped<IArmazenadorLogErro, ArmazenadorLogErro>();
        }
    }
}
