using LineupOptimizer.Domain.Services;
using LineupOptimizer.Mapping;
using LineupOptimizer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LineupOptimizer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = HomeViewModelMapper.Build();
            return View("Index", viewModel);
        }

        [HttpGet]
        public ActionResult Injuries()
        {
            return View("Injuries");
        }

        [HttpGet]
        public JsonResult ActiveOnly()
        {
            var players = (List<PlayerModel>)CacheService.GetObjectFromCache("players");

            return Json(players.Where(x => x.IsActive == true).ToList(), JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public ActionResult MyTeam()
        //{
            
        //}
    }
}