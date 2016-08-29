using a2wd.Umbraco.Models.Reference;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace a2wd.Umbraco.Logic.Helpers
{
    public class Utilities
    {
        public static UmbracoHelper UmbracoHelper()
        {
            return new UmbracoHelper(UmbracoContext.Current);
        }

        public static IPublishedContent SettingsNode()
        {
            UmbracoHelper helper = UmbracoHelper();

            IPublishedContent settingsNode = helper.TypedContentAtRoot()
                .Where(i => i.DocumentTypeAlias.Equals(DocumentTypeAliases.SiteSettings))
                .FirstOrDefault();

            return settingsNode;
        }

        public static string Trim(string source, int length)
        {
            if(source.Length > length)
            {
                return string.Format("{0}...", source.Substring(0, length - 3));
            }

            //Else
            return source;
        }

        public static string StripHtml(string source)
        {
            var strippedHtml = new char[source.Length];
            int arrayIndex = 0;
            bool isHtmlTag = false;

            for(int i = 0; i < source.Length; i++)
            {
                char c = source[i];
                if(c == '<')
                {
                    isHtmlTag = true;
                }
                else if(c == '>')
                {
                    isHtmlTag = false;
                }
                else if(!isHtmlTag)
                {
                    strippedHtml[arrayIndex] = source[i];
                    arrayIndex++;
                }
            }

            return new string(strippedHtml, 0, arrayIndex);
        }
    }
}
