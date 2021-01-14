using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.Features.Models;
using FordIndia.Feature.Features;
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
                        //var image = (ImageField)element.Fields[Templates.LeftImageRightbullet.Fields.HeaderImage];          
                        MultilistField propertyList = element.Fields[Templates.LeftImageRightbullet.Fields.RightBulletList];
                        Item[] items = propertyList.GetItems();
                        prop.Header = !string.IsNullOrEmpty(element.Fields[Templates.LeftImageRightbullet.Fields.Header].Value) ? element.Fields[Templates.LeftImageRightbullet.Fields.Header].Value : string.Empty;
                        prop.BlueTitle = !string.IsNullOrEmpty(element.Fields[Templates.LeftImageRightbullet.Fields.BlueTitle].Value) ? element.Fields[Templates.LeftImageRightbullet.Fields.BlueTitle].Value : string.Empty;
                        var propItem = new List<PropertyItems>();
                        if (items != null)
                        {
                            foreach (Item item in items)
                            {
                                var promoimg = (ImageField)item.Fields[Templates._HasMediaImageItem.Fields.MediaImage];
                                var promoMobImg = (ImageField)item.Fields[Templates._HasMediaImageItem.Fields.MobileImage];
                                var t = new PropertyItems
                                {
                                    Title = !string.IsNullOrEmpty(item.Fields[Templates._HasMediaItem.Fields.MediaTitle].Value) ? item.Fields[Templates._HasMediaItem.Fields.MediaTitle].Value : string.Empty,
                                    Description = !string.IsNullOrEmpty(item.Fields[Templates._HasMediaItem.Fields.MediaDescription].Value) ? item.Fields[Templates._HasMediaItem.Fields.MediaDescription].Value : string.Empty,
                                    Image = promoimg != null && !string.IsNullOrEmpty(promoimg.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(promoimg.MediaItem)) ? MediaManager.GetMediaUrl(promoimg.MediaItem) : string.Empty,
                                    MobileImage= promoMobImg != null && !string.IsNullOrEmpty(promoMobImg.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(promoMobImg.MediaItem)) ? MediaManager.GetMediaUrl(promoMobImg.MediaItem) : string.Empty
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
        public ActionResult StyleComponent()
        {
            var model = new FeaturesDetails();
            var ImageListModel = new List<ImageDetails>();
            var Current = RenderingContext.CurrentOrNull.Rendering.DataSource;

            try
            {
                if (!string.IsNullOrEmpty(Current))
                {
                    Item dataSource = Sitecore.Context.Database.GetItem(Current);
                    if (dataSource.TemplateID == Features.Templates.HeaderItems.ID)
                    {
                        if (dataSource != null && dataSource.GetChildren().Any() && dataSource.GetChildren() != null)
                        {
                            model.BlueTitle = !string.IsNullOrEmpty(dataSource.Fields[Features.Templates.HeaderItems.Fields.BlueTitle].Value) ? dataSource.Fields[Templates.HeaderItems.Fields.BlueTitle].Value : string.Empty;
                            model.Title = !string.IsNullOrEmpty(dataSource.Fields[Features.Templates.HeaderItems.Fields.Title].Value) ? dataSource.Fields[Templates.HeaderItems.Fields.Title].Value : string.Empty;
                            foreach (Item item in dataSource.GetChildren())
                            {
                                var image = (ImageField)item.Fields[Features.Templates.ImageItems.Fields.Image];
                                var MobImage = (ImageField)item.Fields[Features.Templates.ImageItems.Fields.MobileImage];
                                var imageDetails = new ImageDetails
                                {
                                    Heading = !string.IsNullOrEmpty(item.Fields[Features.Templates.ImageItems.Fields.Heading].Value) ? item.Fields[Features.Templates.ImageItems.Fields.Heading].Value : string.Empty,
                                    desc = !string.IsNullOrEmpty(item.Fields[Features.Templates.ImageItems.Fields.Description].Value) ? item.Fields[Features.Templates.ImageItems.Fields.Description].Value : string.Empty,
                                    Image = image != null && !string.IsNullOrEmpty(image.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(image.MediaItem)) ? MediaManager.GetMediaUrl(image.MediaItem) : string.Empty,
                                    MobileImg = MobImage != null && !string.IsNullOrEmpty(MobImage.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(MobImage.MediaItem)) ? MediaManager.GetMediaUrl(MobImage.MediaItem) : string.Empty
                                };
                                ImageListModel.Add(imageDetails);
                            }
                            model.ImageList = ImageListModel;
                            return View("~/Views/Nameplate/StyleComponent.cshtml", model);

                        }
                    }

                    
                }


            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return View();
        }
    }

}