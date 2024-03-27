using Core.Dominio.Comandos;
using Core.Dominio.Consultas;
using Core.Dominio.Mediador.ImplementacoesMediatR;
using Core.Dominio.Mediador;
using Core.Dominio.Notificacoes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Core.Dominio.Eventos;
using MediatR;

namespace Core
{
    public static class InjecaoDeDependencias
    {
        public static IServiceCollection CarregarAssembliesMediatR(this IServiceCollection services, Assembly assembly)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
            return services;

        }

        public static void UsarMediatR(this IServiceCollection services)
        {
            services.CarregarAssembliesMediatR(typeof(NotificacoesDoDominio).Assembly);
            services.AddScoped<IConsultasDoDominio, ConsultasComMediatR>();
            services.AddScoped<IComandosDoDominio, ComandosComMediatR>();
            services.AddScoped<IEventosDoDominio, EventosComMediatR>();
        }

        public static void AdicionarDependenciasCore(this IServiceCollection services)
        {
            services.AddScoped<INotificacoesDoDominio, NotificacoesDoDominio>();
            services.AddScoped<IMediadorDoDominio, MediadorDoDominio>();

        }

    }
}
