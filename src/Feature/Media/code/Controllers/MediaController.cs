﻿using FordIndia.Feature.Media.Repository;
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
                return View("Carousel", model);
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
                        List<TwoBanner> TwobannerCarosel = new List<TwoBanner>();
                        if (Banneritem.Count > 1 && Banneritem.Count == 2)
                        {                           
                            foreach (Item item in Banneritem)
                            {
                                var desktopimage = (ImageField)item.Fields[Templates.ImageItem.MediaImageFieldID];
                                var mobimage = (ImageField)item.Fields[Templates.ImageItem.MobileImage];
                                var twoBanner = new TwoBanner
                                {
                                    MediaTitle = !string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaTitleFieldID].Value) ? item.Fields[Templates.ImageItem.MediaTitleFieldID].Value : string.Empty,
                                    MediaDescription = !string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value) ? item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value : string.Empty,
                                    MediaImage = desktopimage.MediaItem != null && !string.IsNullOrEmpty(desktopimage.Value) ? MediaManager.GetMediaUrl(desktopimage.MediaItem) : string.Empty,
                                    MobileImage = mobimage.MediaItem != null && !string.IsNullOrEmpty(mobimage.Value) ? MediaManager.GetMediaUrl(mobimage.MediaItem) : string.Empty,
                                    Link = !string.IsNullOrEmpty(Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID])) ? Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID]) : string.Empty,
                                };
                                TwobannerCarosel.Add(twoBanner);
                            }
                            return View("~/Views/Media/TwoBanner.cshtml", TwobannerCarosel);
                        }
                        else if (Banneritem.Count > 2 && Banneritem.Count == 3)
                        {
                            foreach (Item item in Banneritem)
                            {
                                var desktopimage = (ImageField)item.Fields[Templates.ImageItem.MediaImageFieldID];
                                var mobimage = (ImageField)item.Fields[Templates.ImageItem.MobileImage];
                                var tileBanner = new TwoBanner
                                {
                                    MediaTitle = !string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaTitleFieldID].Value) ? item.Fields[Templates.ImageItem.MediaTitleFieldID].Value : string.Empty,
                                    MediaDescription = !string.IsNullOrEmpty(item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value) ? item.Fields[Templates.ImageItem.MediaDescriptionFieldID].Value : string.Empty,
                                    MediaImage = desktopimage.MediaItem != null && !string.IsNullOrEmpty(desktopimage.Value) ? MediaManager.GetMediaUrl(desktopimage.MediaItem) : string.Empty,
                                    MobileImage = mobimage.MediaItem != null && !string.IsNullOrEmpty(mobimage.Value) ? MediaManager.GetMediaUrl(mobimage.MediaItem) : string.Empty,
                                    Link = !string.IsNullOrEmpty(Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID])) ? Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID]) : string.Empty,
                                };
                                TwobannerCarosel.Add(tileBanner);
                            }
                            return View("~/Views/Media/BannerTiles.cshtml", TwobannerCarosel);
                        }
                        else if(Banneritem.Count > 0 )
                        {
                            
                            foreach (Item item in Banneritem)
                            {
                                var desktopimage = (ImageField)item.Fields[Templates.ImageItem.MediaImageFieldID];
                                var mobimage = (ImageField)item.Fields[Templates.ImageItem.MobileImage];
                                var tollBanner= new TwoBanner
                                {                                    
                                    MediaImage = desktopimage.MediaItem != null && !string.IsNullOrEmpty(desktopimage.Value) ? MediaManager.GetMediaUrl(desktopimage.MediaItem) : string.Empty,
                                    MobileImage = mobimage.MediaItem != null && !string.IsNullOrEmpty(mobimage.Value) ? MediaManager.GetMediaUrl(mobimage.MediaItem) : string.Empty,
                                    Link = !string.IsNullOrEmpty(Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID])) ? Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID]) : string.Empty,
                                };
                                TwobannerCarosel.Add(tollBanner);
                            }
                            return View("~/Views/Media/TollFreeBanner.cshtml", TwobannerCarosel);

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
        public ActionResult HeroBanner()
        {
            try
            {
                var bannercontext = Sitecore.Context.Item;
                var desktopImage = (ImageField)bannercontext.Fields[Templates.ImageItem.MediaImageFieldID];
                var MobileImage = (ImageField)bannercontext.Fields[Templates.ImageItem.MobileImage];
                var iconImage = (ImageField)bannercontext.Fields[Templates.BannerBreadcrumb.Fields.Image];
                HeroBanner bannerItem = new HeroBanner
                {
                    MediaTitle = !string.IsNullOrEmpty(bannercontext.Fields[Templates.ImageItem.MediaTitleFieldID].Value) ? bannercontext.Fields[Templates.ImageItem.MediaTitleFieldID].Value : string.Empty,
                    MediaImage = desktopImage.MediaItem != null && !string.IsNullOrEmpty(desktopImage.Value) ? MediaManager.GetMediaUrl(desktopImage.MediaItem) : string.Empty,
                    MobileImage = MobileImage.MediaItem != null && !string.IsNullOrEmpty(MobileImage.Value) ? MediaManager.GetMediaUrl(MobileImage.MediaItem) : string.Empty,
                    Title = !string.IsNullOrEmpty(bannercontext.Fields[Templates.BannerBreadcrumb.Fields.Title].Value) ? bannercontext.Fields[Templates.BannerBreadcrumb.Fields.Title].Value : string.Empty,
                    Link = !string.IsNullOrEmpty(Helpers.LinkUrl(bannercontext.Fields[Templates.BannerBreadcrumb.Fields.Link])) ? Helpers.LinkUrl(bannercontext.Fields[Templates.BannerBreadcrumb.Fields.Link]) : string.Empty,
                    Image = iconImage.MediaItem != null && !string.IsNullOrEmpty(iconImage.Value) ? MediaManager.GetMediaUrl(iconImage.MediaItem) : string.Empty,
                };

                return View("~/Views/Media/HeroBanner.cshtml", bannerItem);
            }
            catch (Exception ex)
            {
                return new EmptyResult();
            }

        }
        public ActionResult NameplateBanner()
        {
            try
            {
                var dataSource = RenderingContext.Current.Rendering.Item;
                if (dataSource != null && dataSource.TemplateID == Templates.MediaGroup.ID)
                {
                    var Banner = dataSource.GetChildren();
                    if (Banner.Any())
                    {
                        if (Banner.Count > 0)
                        {
                            List<TwoBanner> Nameplate = new List<TwoBanner>();
                            foreach (Item item in Banner)
                            {
                                var desktopimage = (ImageField)item.Fields[Templates.ImageItem.MediaImageFieldID];
                                var isvideo = (CheckboxField)item.Fields[Templates.ImageItem.IsVideo];
                                var Nameplatebanner = new TwoBanner
                                {
                                    MediaImage = desktopimage.MediaItem != null && !string.IsNullOrEmpty(desktopimage.Value) ? MediaManager.GetMediaUrl(desktopimage.MediaItem) : string.Empty,
                                    VideoLink = !string.IsNullOrEmpty(Helpers.LinkUrl(item.Fields[Templates._HasMediaVideoItem.Fields.MediaVideoLink])) ? Helpers.LinkUrl(item.Fields[Templates._HasMediaVideoItem.Fields.MediaVideoLink]) : string.Empty,
                                    Isvideo = isvideo != null && isvideo.Checked ? true : false,
                                    Link = !string.IsNullOrEmpty(Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID])) ? Helpers.LinkUrl(item.Fields[Templates.ImageItem.LinkFieldID]) : string.Empty,

                                };
                                Nameplate.Add(Nameplatebanner);
                            }
                            return View("~/Views/Media/NameplateBanner.cshtml", Nameplate);
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
        public ActionResult StyleCarousel()
        {
             
            return View();

        }
    }
}