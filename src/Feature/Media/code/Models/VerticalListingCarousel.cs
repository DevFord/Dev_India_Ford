using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Media.Models
{
    public class VerticalListingCarousel
    {
        
        public string BlueTitle { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public List<ImageDetail> ImageList { get; set; }
    }
    public class ImageDetail
    {
        public string Alt { get; set; }
        public string Heading { get; set; }
        public string Description{ get; set; }
        public string Image { get; set; }
        public string MobileImage { get; set; }
    }
}