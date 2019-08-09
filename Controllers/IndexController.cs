using Microsoft.AspNetCore.Mvc;

namespace BizarreStatusServer.Controllers
{
    public class IndexController : Controller
    {
        [Route("/")]
        [Route("index")]
        [Route("api")]
        [Route("api/index")]
        public IActionResult Index()
        {
            ViewData["ApiTitle"] = "Bizarre Status API Server";
            ViewData["Author"] = "seesaw game";

            return View();
        }
    }
}
