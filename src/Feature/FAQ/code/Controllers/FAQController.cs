
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.FAQ.Models;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Presentation;


namespace FordIndia.Feature.FAQ.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult CorporateSR()
        {
            var csrModel = new List<CorporateSR>();
            var dataSource = RenderingContext.CurrentOrNull.Rendering.DataSource;
            try
            {
                if (!string.IsNullOrEmpty(dataSource))
                {
                    Item datasourceItem = Sitecore.Context.Database.GetItem(dataSource);
                    if (datasourceItem != null && datasourceItem.GetChildren() != null && datasourceItem.GetChildren().Any())
                    {
                        foreach (Item item in datasourceItem.GetChildren())
                        {
                            var model = new CorporateSR
                            {
                                Header = !string.IsNullOrEmpty(item.Fields[Templates.FAQ.Fields.Question].Value) ? item.Fields[Templates.FAQ.Fields.Question].Value : string.Empty,
                                Accordian = !string.IsNullOrEmpty(item.Fields[Templates.FAQ.Fields.Answer].Value) ? item.Fields[Templates.FAQ.Fields.Answer].Value : string.Empty,
                                CollapseID = !string.IsNullOrEmpty(item.Fields[Templates.StyleItems.Fields.CollapseId].Value) ? item.Fields[Templates.StyleItems.Fields.CollapseId].Value : string.Empty
                            };
                            csrModel.Add(model);
                        }
                        return View("~/Views/FAQ/CustomerSR.cshtml", csrModel);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Info("-----BreadcrumbNav----", ex);
            }
            return new EmptyResult();
        }
    }
}