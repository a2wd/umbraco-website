using a2wd.Umbraco.Models.PageModels;
using a2wd.Umbraco.Models.Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace a2wd.Umbraco.Logic.Pages
{
    public class BlogPageLogic
    {
        public static BlogPageViewModel Get(IPublishedContent pageItem)
        {
            var model = new BlogPageViewModel();

            Helpers.PopulatePageBase.Fill(model, pageItem);

            model.Tags = pageItem.HasValue(FieldNames.Tags) ? pageItem.GetPropertyValue<string>(FieldNames.Tags) : string.Empty;

            return model;
        }
    }
}
