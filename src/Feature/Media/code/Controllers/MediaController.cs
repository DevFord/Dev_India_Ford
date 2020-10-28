using FordIndia.Feature.Media.Repository;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.Media.Models;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Resources.Media;
using static FordIndia.Foundation.SitecoreExtensions.Extensions.HtmlHelperExtensions;

namespace FordIndia.Feature.Media.Controllers
{
    public class MediaController : Controller
    {
        public readonly IMediaRepository _mediaRepository;

        public MediaController(IMediaRepository mediaRepository)
        {
            this._mediaRepository = mediaRepository;
        }

        public ActionResult MediaCarousel()
        {
            try
            {
                var model = _mediaRepository.GetCarouseItems();
                return View("Carousel",model);
            }
            catch (Exception ex)
            {
                Sitecore.Diagnostics.Log.Error(ex.Message, ex, this);
                return null;
            }
        }
        public ActionResult TwoBanner()
        {
            try
            {
                var dataSource = RenderingContext.Current.Rendering.Item;
                if (dataSource != null && dataSource.TemplateID == Templates.MediaGroup.ID)
                {
                    var Banneritem = dataSource.GetChildren();
                    if (Banneritem.Any())
                    {
                        if (Banneritem.Count > 1 && Banneritem.Count==2)
                        {
                            List<TwoBanner> TwobannerCarosel = new List<TwoBanner>();
                            foreach (Item item in Banneritem)
                            {
                                var desktopimage = (ImageField)item.Fields[Templates.ImageItem.MediaImageFieldID];
                                var mobimage = (ImageField)item.Fields[Templates.ImageItem.MobileImage];
                                var banner = new TwoBanner
                                {
                                  MediaTitle=!string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaTitleFieldID].Value)? item.Fields[Templates.ImageItem.MediaTitleFieldID].Value:string.Empty,
                                  MediaDescription= !string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value)? item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value:string.Empty,
                                  MediaImage= desktopimage.MediaItem != null && !string.IsNullOrEmpty(desktopimage.Value)?MediaManager.GetMediaUrl(desktopimage.MediaItem):string.Empty,
                                  MobileImage = mobimage.MediaItem != null && !string.IsNullOrEmpty(mobimage.Value) ? MediaManager.GetMediaUrl(mobimage.MediaItem) : string.Empty,
                                  Link=!string.IsNullOrEmpty(Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID])) ? Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID]) : string.Empty,
                                };
                                TwobannerCarosel.Add(banner);
                            }
                            return View("~/Views/Media/TwoBanner.cshtml", TwobannerCarosel);
                        }
                        if (Banneritem.Count > 1 && Banneritem.Count == 3)
                        {
                            List<TwoBanner> TwobannerCarosel = new List<TwoBanner>();
                            foreach (Item item in Banneritem)
                            {
                                var desktopimage = (ImageField)item.Fields[Templates.ImageItem.MediaImageFieldID];
                                var mobimage = (ImageField)item.Fields[Templates.ImageItem.MobileImage];
                                var banner = new TwoBanner
                                {
                                    MediaTitle = !string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaTitleFieldID].Value) ? item.Fields[Templates.ImageItem.MediaTitleFieldID].Value : string.Empty,
                                    MediaDescription = !string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value) ? item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value : string.Empty,
                                    MediaImage = desktopimage.MediaItem != null && !string.IsNullOrEmpty(desktopimage.Value) ? MediaManager.GetMediaUrl(desktopimage.MediaItem) : string.Empty,
                                    MobileImage = mobimage.MediaItem != null && !string.IsNullOrEmpty(mobimage.Value) ? MediaManager.GetMediaUrl(mobimage.MediaItem) : string.Empty,
                                    Link = !string.IsNullOrEmpty(Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID])) ? Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID]) : string.Empty,
                                };
                                TwobannerCarosel.Add(banner);
                            }
                            return View("~/Views/Media/BannerTiles.cshtml", TwobannerCarosel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new EmptyResult();
            }
            return new EmptyResult();
        }

    }
}