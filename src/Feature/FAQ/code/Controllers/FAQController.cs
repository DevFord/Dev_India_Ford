
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.FAQ.Models;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;


namespace FordIndia.Feature.FAQ.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult FAQ()
        {
            //try
            //{
            //    List<FAQ> faq = new List<FAQ>();
            //    Database currentDB = Sitecore.Context.Database;
            //    Item CurrentItem = RenderingContext.Current.Rendering.Item;
            //    Item faqCategoryFolder = currentDB.GetItem(FolderID.FAQFiltersID);
            //    Item faqContentFolder = currentDB.GetItem(FolderID.FAQID);
            //    FAQCategoryList = getFAQCategories(faqCategoryFolder);
            //}
            //catch (Exception ex)
            //{

            //}
            return View();
        }
    }
}