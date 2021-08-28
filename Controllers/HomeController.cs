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

        public ActionResult Index(string search)
        {
            this.ViewBag.Search = search; 
            return View();
        }

      public async Task<ActionResult> SearchHero(string search)
        {
          string response = await requestAccess.SearchHero(search);
            ResultModel result = JsonConvert.DeserializeObject<ResultModel>(response);
            List<HeroModel> model = result.Results;
            this.ViewBag.SearchString = search;
            return View("_resultSearch", model);
        }

        [Route("character/{heroId}")]
        public async Task<ActionResult> GetHeroById(int heroId,string lastSearch)
        {
            string response = await requestAccess.GetHero(heroId);
            HeroModel model = JsonConvert.DeserializeObject<HeroModel>(response);
            this.ViewBag.LastSearch = lastSearch;
            if (model.Id == 0)
            {
                return View("NotFound");
            }
            return View("_heroSearch",model);
        }
    }
}