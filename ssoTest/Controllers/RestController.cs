using System;
using System.Net;
using System.Web.Mvc;
using ssoTest.Business;

namespace ssoTest.Controllers
{
    public class RestController : Controller
    {
        public ActionResult SsoAuth(string ssoToken)
        {
            var result = new GradeBusiness().GetGradeResponse(ssoToken);

            HttpStatusCode code;

            if (!Enum.TryParse(result.StatusCode, out code))
                code = HttpStatusCode.OK;

            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = (int)code;

            return View(result);
        }
    }
}
