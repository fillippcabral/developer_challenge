using Core;
using Dominio;
using Infraestrutura;

namespace Develop_Challenge_API
{
    public static class InjecaoDeDependencias
    {
        public static IServiceCollection IncluirTodasAsDependencias(this IServiceCollection services)
        {
            services.UsarMediatR();
            services.AdicionarDependenciasCore();
            services.AdicionarDependenciasDoDominio();
            services.AdicionarDependenciasDeBancoDeDados();

            return services;

        }
    }
}
