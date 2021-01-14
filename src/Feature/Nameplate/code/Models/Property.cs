using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Nameplate.Models
{
    public class Property
    {
        public string Header { get; set; }
        public string BlueTitle { get; set; }
        public List<PropertyItems> propertyItems { get; set; }
    }
    public class PropertyItems
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string MobileImage { get; set; }
    }
}