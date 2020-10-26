using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Navigation.Models
{
    public class NavigationItem
    {
        public Item Item { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public NavigationItems Children { get; set; }
        public string Target { get; set; }
        public bool ShowChildren { get; set; }
        public ImageField Image { get; set; }
    }
    public class NavigationItems
    {
        public IList<NavigationItem> NavItems { get; set; }
    }
}