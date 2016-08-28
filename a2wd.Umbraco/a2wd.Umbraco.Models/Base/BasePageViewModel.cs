using a2wd.Umbraco.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2wd.Umbraco.Models.Base
{
    public class BasePageViewModel
    {
        public IEnumerable<LinkModel> Navigation { get; set; }
        public string PageTitle { get; set; }
        public string BodyContent { get; set; }
        public string MetaTags { get; set; }
        public string MetaDescription { get; set; }
    }
}
