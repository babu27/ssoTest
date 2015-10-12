using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using ssoTest.Business;

namespace ssoTest.Controllers.Api
{
    public class RestController : ApiController
    {
        //// GET api/rest
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/rest/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

      

        // PUT api/rest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/rest/5
        public void Delete(int id)
        {
        }

        // ssoauth  api/rest/ssoauthGet
        
        [HttpGet]
        [ActionName("ssoauthGet")]
        public object ssoauthGet(int? id=null)
        {
            return new {AdminUserId = "p", Result = "0000"};
        }

        [HttpPost]
        public HttpResponseMessage ssoauth([FromBody] string ssoToken)
        {
            var result = new GradeBusiness().GetGradeResponse(ssoToken);

            return Request.CreateResponse(HttpStatusCode.OK, result,new JsonMediaTypeFormatter());
        }
    }
}
