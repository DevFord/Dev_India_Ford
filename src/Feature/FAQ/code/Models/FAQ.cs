using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.FAQ.Models
{
    public class FAQ
    {
        public List<Item> FAQCategoryList { get; set; }

        public List<FAQItems> FAQList { get; set; }
    }
    public class FAQItems
    {
        public Item FAQCategory;
        public List<Item> FAQs;

    }
}