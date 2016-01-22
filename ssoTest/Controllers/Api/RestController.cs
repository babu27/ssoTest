using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using ssoTest.Business;
using ssoTest.Entity;

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
        public HttpResponseMessage ssoauth()
        {
            var ssoToken = string.Empty;
            var ssoTokenName = string.Empty;

            using (var requestStream = HttpContext.Current.Request.InputStream)
            {
                requestStream.Seek(0, SeekOrigin.Begin);

                var rawBody = new StreamReader(requestStream).ReadToEnd();

                if (!string.IsNullOrEmpty(rawBody))
                {
                    var ary=rawBody.Split("=".ToCharArray(),2);

                    if (ary.Length != 2 || !ConfigHelper.IsValidToken(ary[0]))
                        return Request.CreateErrorResponse(HttpStatusCode.Unauthorized,new Exception("testing"));

                    ssoToken = ary[1];
                    ssoTokenName = ary[0];

                }
            }

            var result = new GradeBusiness().GetGradeResponse(ssoToken, ssoTokenName);

            HttpStatusCode code;

            if (!Enum.TryParse(result.StatusCode, out code))
                code = HttpStatusCode.OK;

            return Request.CreateResponse(code, result, new JsonMediaTypeFormatter());

        }
    }
}
