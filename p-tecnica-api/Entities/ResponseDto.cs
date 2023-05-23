using Newtonsoft.Json;

namespace p_tecnica_api.Entities
{
    public class ResponseDto
    {
        [JsonProperty("codigoEnvio")]
        public string Codigo { get; set; }

        [JsonProperty("estado")]
        public string Mensaje {get; set;}

    }
}