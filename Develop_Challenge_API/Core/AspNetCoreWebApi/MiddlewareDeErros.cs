using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Core.Dominio.Mediador;
using Core.Dominio.Extensoes;
using Newtonsoft.Json;

namespace Core.AspNetCoreWebApi
{
    public class MiddlewareDeErros
    {
        private const string CodigoDeErro = "[Erro_Dominio]";
        private readonly RequestDelegate _next;
        private readonly ILogger<ControllerBase> _logger;

        public MiddlewareDeErros(RequestDelegate next, ILogger<ControllerBase> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context, IMediadorDoDominio mediador)
        {
            try
            {
                await _next(context);

            }
            catch (Exception ex)
            {
                await TratarExcecao(context, ex, mediador);
            }
        }

        private Task TratarExcecao(HttpContext context, Exception ex, IMediadorDoDominio mediador)
        {
            ErroDTO erro;
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (environment != "Development" && environment != "Qa")
                erro = new ErroDTO($"Tivemos um problema, por favor, verique os logs.");
            else
                erro = new ErroDTO(ex.InnerExceptionRaiz(), ex);

            var referencia = $" - Ref.: {erro.Id} - ";

            mediador.Notificacoes.Adicionar($"{erro.Mensagem} {referencia}", exibirParaUsuario: false);

            _logger.LogError(CodigoDeErro + referencia + ex.InnerExceptionRaiz());



            RetornoPadraoDaApi<object> resposta = new()
            {
                Sucedido = false,
                Notificacoes = mediador.Notificacoes.Listar,

            };

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/problem+json";
            return context.Response.WriteAsync(JsonConvert.SerializeObject(resposta));

        }

    }
}
