using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;
using FordIndia.Feature.PageContent.Models;
using FordIndia.Foundation.SitecoreExtensions.Extensions;
using Sitecore.Diagnostics;
using Sitecore.Data.Items;

namespace FordIndia.Feature.PageContent.Controllers
{
    public class PageContentController : Controller
    {
        // GET: PageContent
        public ActionResult ContactUs()
        {
            try
            {
                var context = Sitecore.Context.Item;
                if (context != null)
                {
                    var emailImage = (ImageField)context.Fields[Templates.PageContentImage.Fields.EmailImage];
                    var smslImage = (ImageField)context.Fields[Templates.PageContentImage.Fields.EmailImage];
                    var tollImage = (ImageField)context.Fields[Templates.PageContentImage.Fields.EmailImage];
                    Content pageContent = new Content
                    {
                        HeaderTitle = !string.IsNullOrEmpty(context.Fields[Templates.PageContent.Fields.HeaderTitle].Value) ? context.Fields[Templates.PageContent.Fields.HeaderTitle].Value : string.Empty,
                        HeaderDesc = !string.IsNullOrEmpty(context.Fields[Templates.PageContent.Fields.HeaderDescription].Value) ? context.Fields[Templates.PageContent.Fields.HeaderDescription].Value : string.Empty,
                        HeaderSummary = !string.IsNullOrEmpty(context.Fields[Templates.PageContent.Fields.HeaderSummary].Value) ? context.Fields[Templates.PageContent.Fields.HeaderSummary].Value : string.Empty,
                        Title = !string.IsNullOrEmpty(context.Fields[Templates.PageContentImage.Fields.Title].Value) ? context.Fields[Templates.PageContentImage.Fields.Title].Value : string.Empty,
                        Description = !string.IsNullOrEmpty(context.Fields[Templates.PageContentImage.Fields.Description].Value) ? context.Fields[Templates.PageContentImage.Fields.Description].Value : string.Empty,
                        EmailImage = emailImage.MediaItem != null && !string.IsNullOrEmpty(emailImage.Value) ? MediaManager.GetMediaUrl(emailImage.MediaItem) : string.Empty,
                        EmailDesc = !string.IsNullOrEmpty(context.Fields[Templates.PageContentImage.Fields.EmailDescription].Value) ? context.Fields[Templates.PageContentImage.Fields.EmailDescription].Value : string.Empty,
                        SmsImage = smslImage.MediaItem != null && !string.IsNullOrEmpty(smslImage.Value) ? MediaManager.GetMediaUrl(smslImage.MediaItem) : string.Empty,
                        SmsDesc = !string.IsNullOrEmpty(context.Fields[Templates.PageContentImage.Fields.SmsDescription].Value) ? context.Fields[Templates.PageContentImage.Fields.SmsDescription].Value : string.Empty,
                        TollImage = smslImage.MediaItem != null && !string.IsNullOrEmpty(tollImage.Value) ? MediaManager.GetMediaUrl(tollImage.MediaItem) : string.Empty,
                        TollDesc = !string.IsNullOrEmpty(context.Fields[Templates.PageContentImage.Fields.TollFreeDescription].Value) ? context.Fields[Templates.PageContentImage.Fields.TollFreeDescription].Value : string.Empty,
                    };
                    return View("~/Views/PageContent/ContactUs.cshtml", pageContent);
                }
            }
            catch (Exception ex)
            {
                Log.Info("-----Error in Contact Us Page--------", ex.Message);

            }
            return new EmptyResult();
        }
        public ActionResult InterestedSection()
        {
            var currentContext = Sitecore.Context.Item;
            try
            {
                if (currentContext != null)
                {
                    InterestedModel model = new InterestedModel
                    {
                        Title = !string.IsNullOrEmpty(currentContext.Fields[Templates.InterestedSectionItem.Fields.Title].Value) ? currentContext.Fields[Templates.InterestedSectionItem.Fields.Title].Value : string.Empty,
                        Description = !string.IsNullOrEmpty(currentContext.Fields[Templates.InterestedSectionItem.Fields.Description].Value) ? currentContext.Fields[Templates.InterestedSectionItem.Fields.Description].Value : string.Empty,
                        QuotesLink = !string.IsNullOrEmpty(CustomSCExtension.LinkUrl(currentContext.Fields[Templates.InterestedSectionItem.Fields.QuoteLink])) ? CustomSCExtension.LinkUrl(currentContext.Fields[Templates.InterestedSectionItem.Fields.QuoteLink]) : string.Empty,
                        Link = !string.IsNullOrEmpty(CustomSCExtension.LinkUrl(currentContext.Fields[Templates.InterestedSectionItem.Fields.Link])) ? CustomSCExtension.LinkUrl(currentContext.Fields[Templates.InterestedSectionItem.Fields.Link]) : string.Empty
                    };
                    return View("~/Views/PageContent/InterestedSection.cshtml", model);
                }
            }
            catch (Exception ex)
            {
                Log.Info("-----Error in Interested  Section --------", ex.Message);
            }
            return new EmptyResult();
        }
        public ActionResult Disclaimer()
        {
            try
            {
                DisclaimerModel disclaimerModel = new DisclaimerModel();
                Item item = Sitecore.Context.Item;
                if (item != null)
                {
                    disclaimerModel.DisclaimerHeader = !string.IsNullOrEmpty(item.Fields[Templates.DisclaimerContent.Fields.DisclaimerHeader].Value) ? item.Fields[Templates.DisclaimerContent.Fields.DisclaimerHeader].Value : string.Empty;

                    disclaimerModel.DisclaimerDeacription = !string.IsNullOrEmpty(item.Fields[Templates.DisclaimerContent.Fields.DisclaimerDeacription].Value) ? item.Fields[Templates.DisclaimerContent.Fields.DisclaimerDeacription].Value : string.Empty;
                }
                return View("~/Views/PageContent/Disclaimer.cshtml", disclaimerModel);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return View();
        }
    }
}