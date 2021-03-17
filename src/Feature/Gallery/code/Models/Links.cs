using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Gallery.Models
{
    
    public class LinkList
    {
        public string BlueTitle { get; set; }
        public string Title { get; set; }
        public string IconImage { get; set; }
        public string IconImageAlt { get; set; }
        public string BackgroundImg { get; set; }
        public string BackGroundAlt { get; set; }
        public List<Links> linkList{ get; set; }
    }
    public class Links
    {
        public string ExteriorLink { get; set; }
        public string ExteriorAlt{ get; set; }
        public string InteriorLink{ get; set; }
        public string InteriorAlt { get; set; }
    }
}