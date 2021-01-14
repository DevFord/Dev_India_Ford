using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Features.Models
{
    public class FeaturesDetails
    {
        public string BlueTitle { get; set; }
        public string Title { get; set; }
        //public bool IsFourth { get; set; }
        public List<ImageDetails> ImageList { get; set; }
       
    }
    public class ImageDetails
    {
        public string Heading { get; set; }
        public string desc { get; set; }
        public string Image { get; set; }
        public string MobileImg { get; set; }
    }
}