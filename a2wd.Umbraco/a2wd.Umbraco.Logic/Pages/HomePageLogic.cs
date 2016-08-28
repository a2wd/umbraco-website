using a2wd.Umbraco.Logic.Helpers;
using a2wd.Umbraco.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace a2wd.Umbraco.Logic.Pages
{
    public class HomePageLogic
    {
        public static HomePageViewModel Get(IPublishedContent pageItem)
        {
            var model = new HomePageViewModel();

            PopulatePageBase.Fill(model, pageItem);

            return model;
        }
    }
}
