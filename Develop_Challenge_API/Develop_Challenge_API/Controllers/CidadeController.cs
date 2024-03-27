using Core.AspNetCoreWebApi;
using Core.Dominio.Mediador;
using Dominio.Comandos.Cidade;
using Dominio.Respostas.Cidade;
using Microsoft.AspNetCore.Mvc;

namespace Develop_Challenge_API.Controllers
{
    [ApiController]
    [Route("Cidade")]
    public class CidadeController : ControllerApiBase
    {
        public CidadeController(IMediadorDoDominio mediador) : base(mediador)
        {
        }

        /// <summary>
        /// Previsão meteorológica para uma cidade
        /// </summary>
        /// <returns>Retorna Previsão meteorológica para 1 dia na cidade informada.</returns>
        /// <response code="200">Retorna as condições meteorológicas</response>
        [HttpGet]
        [Route("ObterClimaCidade")]
        public async Task<ActionResult<RetornoPadraoDaApi<RespostaCidade?>>> ObterClimaAeroporto([FromQuery] ComandoObterClimaCidade comando)
        {
            var resposta = await _mediador.Comandos.Enviar(comando);
            return EnviarResposta(resposta);
        }
    }
}
