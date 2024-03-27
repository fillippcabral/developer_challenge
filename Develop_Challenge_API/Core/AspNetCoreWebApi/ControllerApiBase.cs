using Core.Dominio.Mediador;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AspNetCoreWebApi
{
    public class ControllerApiBase : ControllerBase
    {
        protected readonly IMediadorDoDominio _mediador;

        public ControllerApiBase(IMediadorDoDominio mediador)
        {
            _mediador = mediador;

        }

        protected ActionResult<RetornoPadraoDaApi<T?>> EnviarResposta<T>(T? resposta) where T : new()
        {
            if (_mediador.Notificacoes.ContemNotificacao)
            {
                if (_mediador.Notificacoes.FoiInterrompido)
                    return BadRequest(new RetornoPadraoDaApi()
                    {
                        Notificacoes = _mediador.Notificacoes.Listar,
                        Sucedido = false,

                    });
                else
                    return Ok(new RetornoPadraoDaApi<T>()
                    {
                        Notificacoes = _mediador.Notificacoes.Listar,
                        Resposta = resposta

                    });

            }
            else if (resposta is null)
                return NotFound(new RetornoPadraoDaApi<T>()
                {
                    Sucedido = false,

                });

            return Ok(new RetornoPadraoDaApi<T>() { Resposta = resposta });

        }

        protected ActionResult<RetornoPadraoDaApi> SemResposta()
        {
            if (_mediador.Notificacoes.ContemNotificacao)
            {
                if (_mediador.Notificacoes.FoiInterrompido)
                    return BadRequest(new RetornoPadraoDaApi()
                    {
                        Notificacoes = _mediador.Notificacoes.Listar,
                        Sucedido = false,

                    });
                else
                    return Ok(new RetornoPadraoDaApi()
                    {
                        Notificacoes = _mediador.Notificacoes.Listar,

                    });

            }

            return Ok(new RetornoPadraoDaApi());

        }

    }
}
