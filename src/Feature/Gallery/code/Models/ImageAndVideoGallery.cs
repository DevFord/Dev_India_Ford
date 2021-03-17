using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Gallery.Models
{
    public class ImageAndVideoGallery
    {
        public string HeaderImage { get; set; }

        public string Image360degree { get; set; }

        public string MainImage { get; set; }
        public string DesignHeader { get; set; }

        public string DesignSubHeader { get; set; }
        public string VideoGalleryHeader { get; set; }
        public string VideoGallerySubHeader { get; set; }
        public string ImageGalleryHeader { get; set; }
        public string ImageGallerySubHeader { get; set; }
        public List<CarProperty> CarImages { get; set; }

        public List<string> VideoImage { get; set; }
        public List<string> GalleryImage { get; set; }
    }

    public class CarProperty
    {
        public string CarImage { get; set; }
        public string ImageName { get; set; }
    }
}