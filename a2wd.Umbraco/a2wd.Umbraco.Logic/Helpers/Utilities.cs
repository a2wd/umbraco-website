using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web;

namespace a2wd.Umbraco.Logic.Helpers
{
    public class Utilities
    {
        public static UmbracoHelper UmbracoHelper()
        {
            return new UmbracoHelper(UmbracoContext.Current);
        }
    }
}
