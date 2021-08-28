using Newtonsoft.Json;
using superHeroApp.Models;
using superHeroApp.Models.RequestAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace superHeroApp.Controllers
{
    public class HomeController : Controller
    {
        private RequestAccess requestAccess;

        public HomeController()
        {
            requestAccess = new RequestAccess();
        }

        public ActionResult Index()
        {
            return View();
        }

      public async Task<ActionResult> SearchHero(string search)
        {
          string response = await requestAccess.SearchHero(search);
            ResultModel result = JsonConvert.DeserializeObject<ResultModel>(response);
            List<HeroModel> model = result.Results;
            return View("_resultSearch", model);
        }

        [Route("/character/{heroId}")]
        public ActionResult GetHeroById(int heroId)
        {
            return View("_heroSearch");
        }
    }
}