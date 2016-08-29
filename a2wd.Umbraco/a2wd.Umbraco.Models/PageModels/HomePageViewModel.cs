using a2wd.Umbraco.Models.Base;
using a2wd.Umbraco.Models.Common;
using System.Collections.Generic;

namespace a2wd.Umbraco.Models.PageModels
{
    public class HomePageViewModel : BasePageViewModel
    {
        public IEnumerable<BlogExtractModel> BlogPages { get; set; }
    }
}
