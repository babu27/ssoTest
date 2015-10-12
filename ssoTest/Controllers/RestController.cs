using System.Web.Mvc;

namespace ssoTest.Controllers
{
    public class RestController : Controller
    {
        public ActionResult SsoAuth(string ssoTken)
        {
            ViewBag.AdminUserId = "p";//assigned based on the input value
            ViewBag.Result = "0000"; // assigned based on the input value.

            return View(ssoTken);
        }
    }
}
