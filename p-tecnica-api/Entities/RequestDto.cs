using Newtonsoft.Json;

namespace p_tecnica_api.Entities
{
    public class RequestDto
    {
        [JsonProperty("numPedido")]
        public string Pedido { get; set; }

        [JsonProperty("cantidadPedido")]
        public int    Cantidad { get; set; }

        [JsonProperty("codigoEAN")]
        public string EAN { get; set; }

        [JsonProperty("nombreProducto")]
        public string Producto { get; set; }

        [JsonProperty("numDocumento")]
        public string Cedula { get; set; }

        [JsonProperty("direccion")]
        public string Direccion { get; set; }

    }
}