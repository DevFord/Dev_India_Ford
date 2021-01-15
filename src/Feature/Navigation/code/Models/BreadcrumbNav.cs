using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Navigation.Models
{
    public class BreadcrumbNav
    {
        public string TitleName { get; set; }
        public bool ShowMenu { get; set; }
        public bool ShowChildren { get; set; }
        public string Link { get; set; }
        public string childTitleName { get; set; }
        public string childLink { get; set; }
        public  List<BreadcrumbchildNav> navchildItems { get; set; }
        public List<BreadcrumbNav> navItems { get; set; }
    }
    public class BreadcrumbchildNav
    {
        public string childTitleName { get; set; }
        public string childLink { get; set; }
    }
}