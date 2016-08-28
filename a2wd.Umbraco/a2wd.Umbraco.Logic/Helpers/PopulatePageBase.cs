using a2wd.Umbraco.Models.Base;
using a2wd.Umbraco.Models.Reference;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace a2wd.Umbraco.Logic.Helpers
{
    public class PopulatePageBase
    {
        public static void Fill(BasePageViewModel model, IPublishedContent pageItem)
        {
            model.BodyContent = pageItem.HasValue(FieldNames.BodyContent) ? pageItem.GetPropertyValue<string>(FieldNames.BodyContent) : string.Empty;
            model.MetaDescription = pageItem.HasValue(FieldNames.MetaDescription) ? pageItem.GetPropertyValue<string>(FieldNames.MetaDescription) : string.Empty;
            model.MetaTags = pageItem.HasValue(FieldNames.MetaTags) ? pageItem.GetPropertyValue<string>(FieldNames.MetaTags) : string.Empty;
        }
    }
}
