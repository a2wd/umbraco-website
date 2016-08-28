using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using a2wd.Umbraco.Models.PageModels;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using a2wd.Umbraco.Logic.Pages;

namespace a2wd.Umbraco.Controllers
{
    public class HomePageController : RenderMvcController
    {
        // GET: HomePage
        public ActionResult Index()
        {
            HomePageViewModel model = HomePageLogic.Get(CurrentPage);
            return CurrentTemplate(model);
        }
    }
}