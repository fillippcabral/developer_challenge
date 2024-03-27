using Dominio.Externo.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dominio.Externo
{
    public class ApiBrasil : ApiBase
    {

        public async Task<ClimaAeroportoDto> GetClimaAeroporto(string codigoIcao)
        {
            return await GetAsync<ClimaAeroportoDto>($"api/cptec/v1/clima/aeroporto/{codigoIcao}");
        }

        public async Task<ClimaCidadeDto> GetClimaCidade(string codigoCidade)
        {
            return await GetAsync<ClimaCidadeDto>($"/api/cptec/v1/clima/previsao/{codigoCidade}");
        }
    }
}
