

using Microsoft.Web.Http;
using System.Web.Http;

namespace WebAPI2Swagger.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/Home")]
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Home");
        }
    }
}
