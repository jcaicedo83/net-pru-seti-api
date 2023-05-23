using p_tecnica_api.Application;
using p_tecnica_api.Entities;
using System.Web.Http;

namespace p_tecnica_api.Controllers
{
    [Route("api/[controller]")]
    public class SetiController : ApiController
    {
        private setiApplication app = new setiApplication();

        [HttpPost]
        [Route("enviar-pedido")]
        public IHttpActionResult EnviarPedido([FromBody] RequestDto item)
        {
            ResponseDto response = app.enviarPedido(item);
            return Ok(response);
        }
    }
}
