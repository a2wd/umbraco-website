using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2wd.Umbraco.Models.Common
{
    public class BlogExtractModel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Extract { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Tags { get; set; }
    }
}
