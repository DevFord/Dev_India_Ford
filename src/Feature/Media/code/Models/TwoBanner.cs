using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Media.Models
{
    public class TwoBanner
    {
        public Item CurrentItem { get; set; }
        public string  MediaTitle { get; set; }
        public  string MediaDescription { get; set; }     
        public string  MediaThumbnail { get; set; }      
        public string MediaImage { get; set; }       
        public string Link { get; set; }
        public string MobileImage { get; set; }
    }
}