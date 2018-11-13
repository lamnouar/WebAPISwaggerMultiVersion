using Microsoft.Web.Http;
using System.Web.Http;

namespace WebAPI2Swagger.Controllers.V1
{
    [ApiVersion("1.0")]
    [RoutePrefix("api/v{version:apiVersion}/Values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route]
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "value1 of v1", "value2 of v1" });
        }

        // GET api/values/5
        [Route("{id}")]
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
