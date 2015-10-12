using System.Web.Mvc;
using ssoTest.Business;

namespace ssoTest.Controllers
{
    public class RestController : Controller
    {
        public ActionResult SsoAuth(string ssoTken)
        {
            var result = new GradeBusiness().GetGradeResponse(ssoTken);

            return View(result);
        }
    }
}
