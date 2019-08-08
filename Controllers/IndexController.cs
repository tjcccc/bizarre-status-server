using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BizarreStatusServer.Controllers
{
    public class IndexController : Controller
    {
        [Route("/")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewData["ApiTitle"] = "Bizarre Status API Server";
            ViewData["Author"] = "seesaw game";

            return View();
        }
    }
}
