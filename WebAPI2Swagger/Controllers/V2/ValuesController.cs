using Microsoft.Web.Http;
using System.Web.Http;

namespace WebAPI2Swagger.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/Values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "value1 of v2", "value2 of v2" });
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]string value)
        {
            return Ok();
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
