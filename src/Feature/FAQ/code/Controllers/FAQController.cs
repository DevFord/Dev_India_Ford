
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.FAQ.Models;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;


namespace FordIndia.Feature.FAQ.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult faq()
        {
            return View();
        }
    }
}