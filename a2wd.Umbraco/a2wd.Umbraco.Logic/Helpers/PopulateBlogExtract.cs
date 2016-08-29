using a2wd.Umbraco.Models.Common;
using a2wd.Umbraco.Models.Reference;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace a2wd.Umbraco.Logic.Helpers
{
    public class PopulateBlogExtract
    {
        public static void Fill(List<BlogExtractModel> model, IEnumerable<IPublishedContent> blogItems, int extractLength)
        {
            foreach (var blog in blogItems)
            {
                var blogItem = new BlogExtractModel();
                Fill(blogItem, blog, extractLength);

                model.Add(blogItem);
            }
        }

        public static void Fill(BlogExtractModel model, IPublishedContent item, int extractLength)
        {
            model.Title = item.Name;
            model.PublishedDate = item.CreateDate;
            model.Link = item.Url();

            model.Tags = item.HasValue(FieldNames.Tags) ? item.GetPropertyValue<string>(FieldNames.Tags) : string.Empty;

            if (item.HasValue(FieldNames.BodyContent))
            {
                string blogContent = Utilities.StripHtml(item.GetPropertyValue<string>(FieldNames.BodyContent));
                model.Extract = Utilities.Trim(blogContent, extractLength);
            }
            else
            {
                model.Extract = string.Empty;
            }
        }

    }
}
