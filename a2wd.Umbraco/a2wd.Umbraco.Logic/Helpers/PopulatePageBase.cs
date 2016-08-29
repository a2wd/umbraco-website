using a2wd.Umbraco.Models.Base;
using a2wd.Umbraco.Models.Common;
using a2wd.Umbraco.Models.Reference;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace a2wd.Umbraco.Logic.Helpers
{
    public class PopulatePageBase
    {
        public static void Fill(BasePageViewModel model, IPublishedContent pageItem)
        {
            model.PageTitle = pageItem.Name;
            model.BodyContent = pageItem.HasValue(FieldNames.BodyContent) ? pageItem.GetPropertyValue<string>(FieldNames.BodyContent) : string.Empty;
            model.MetaDescription = pageItem.HasValue(FieldNames.MetaDescription) ? pageItem.GetPropertyValue<string>(FieldNames.MetaDescription) : string.Empty;
            model.MetaTags = pageItem.HasValue(FieldNames.MetaTags) ? pageItem.GetPropertyValue<string>(FieldNames.MetaTags) : string.Empty;
        }

        public static void FillNavigation(BasePageViewModel model)
        {
            var settingsNode = Utilities.SettingsNode();

            if(settingsNode.HasValue(FieldNames.MainNavigation))
            {
                model.Navigation = settingsNode.GetPropertyValue<IEnumerable<LinkModel>>(FieldNames.MainNavigation);
            }
        }
    }
}
