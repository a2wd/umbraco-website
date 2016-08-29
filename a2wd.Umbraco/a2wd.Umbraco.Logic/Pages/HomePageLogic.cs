using a2wd.Umbraco.Logic.Helpers;
using a2wd.Umbraco.Models.Common;
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
    public class HomePageLogic
    {
        public static HomePageViewModel Get(IPublishedContent pageItem)
        {
            var model = new HomePageViewModel();

            //Fill default properties
            PopulatePageBase.Fill(model, pageItem);

            //Collate blogs
            model.BlogPages = GetBlogPages(pageItem);

            return model;
        }

        private static IEnumerable<BlogExtractModel> GetBlogPages(IPublishedContent pageItem)
        {
            var blogPages = new List<BlogExtractModel>();

            var blogChildren = Utilities.UmbracoHelper()
                .TypedContentAtRoot()
                .DescendantsOrSelf(DocumentTypeAliases.BlogPage);

            int extractLength = 500;
            var settingsNode = Utilities.SettingsNode();
            if(settingsNode.HasValue(FieldNames.BlogExtractLength))
            {
                extractLength = settingsNode.GetPropertyValue<int>(FieldNames.BlogExtractLength);
            }

            PopulateBlogExtract.Fill(blogPages, blogChildren, extractLength);

            return blogPages;
        }
    }
}
