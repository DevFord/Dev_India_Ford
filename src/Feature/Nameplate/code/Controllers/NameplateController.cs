using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.Nameplate.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;

namespace FordIndia.Feature.Nameplate.Controllers
{
    public class NameplateController : Controller
    {
        // GET: Nameplate
        public ActionResult GetAmount()
        {
            return View("~/Views/Nameplate/AjaxTest.cshtml");
        }
        public ActionResult Properties()
        {
            var prop = new Property();
            var Current = RenderingContext.Current.Rendering.Item;
            try
            {
                if (Current!=null)
                {
                    Item element = Sitecore.Context.Item;
                    if (element != null)
                    {
                        var image = (ImageField)element.Fields[Templates.LeftImageRightbullet.Fields.HeaderImage];          
                        MultilistField propertyList = element.Fields[Templates.LeftImageRightbullet.Fields.RightBulletList];
                        Item[] items = propertyList.GetItems();
                        prop.Header = !string.IsNullOrEmpty(element.Fields[Templates.LeftImageRightbullet.Fields.Header].Value) ? element.Fields[Templates.LeftImageRightbullet.Fields.Header].Value : string.Empty;
                        prop.HeaderImage = image!=null&&!string.IsNullOrEmpty(image.Value)&&!string.IsNullOrEmpty(MediaManager.GetMediaUrl(image.MediaItem) )? MediaManager.GetMediaUrl(image.MediaItem): string.Empty;                       
                        var propItem = new List<PropertyItems>();
                        if (items != null)
                        {
                            foreach (Item item in items)
                            {
                                var promoimg = (ImageField)item.Fields[Templates._HasMediaImageItem.Fields.MediaImage];
                                var t = new PropertyItems
                                {
                                    Title = !string.IsNullOrEmpty(item.Fields[Templates._HasMediaItem.Fields.MediaTitle].Value) ? item.Fields[Templates._HasMediaItem.Fields.MediaTitle].Value : string.Empty,
                                    Description = !string.IsNullOrEmpty(item.Fields[Templates._HasMediaItem.Fields.MediaDescription].Value) ? item.Fields[Templates._HasMediaItem.Fields.MediaDescription].Value : string.Empty,
                                    Image = promoimg != null && !string.IsNullOrEmpty(promoimg.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(promoimg.MediaItem)) ? MediaManager.GetMediaUrl(promoimg.MediaItem) : string.Empty
                                };
                                propItem.Add(t);
                            }
                            prop.propertyItems = propItem;
                            return View("~/Views/Nameplate/LeftImageRightbullet.cshtml", prop);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return new EmptyResult();
        }       
    }
}