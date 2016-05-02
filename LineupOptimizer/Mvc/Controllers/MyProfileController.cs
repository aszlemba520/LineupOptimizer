using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LineupOptimizer.Mvc.Controllers
{
    public class MyProfileController : Controller
    {
        [HttpGet]
        public ActionResult Index(Guid indKey)
        {
            return View();
        }

    }
}
