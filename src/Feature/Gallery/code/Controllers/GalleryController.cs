using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FordIndia.Feature.Gallery;
using FordIndia.Feature.Gallery.Models;
using System.Web.Mvc;
using Sitecore.Diagnostics;
using Sitecore.Data.Items;
using FordIndia.Foundation.SitecoreExtensions.Extensions;
using Sitecore.Resources.Media;
using Sitecore.Data.Fields;

namespace FordIndia.Feature.Gallery.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult InteriorExterior()
        {

            var model = new LinkList();
            var linkList = new List<Links>();
            var context = Sitecore.Context.Item;
            var DataSource = RenderingContext.CurrentOrNull.Rendering.DataSource;
            try
            {
                if (context != null)
                {
                    if (!string.IsNullOrEmpty(CustomSCExtension.LinkUrl(context.Fields[Templates._LinkItems.Fields.Exterior])) || !string.IsNullOrEmpty(CustomSCExtension.LinkUrl(context.Fields[Templates._LinkItems.Fields.Interior])))
                    {
                        LinkField Exteriorlf = context.Fields[Templates._LinkItems.Fields.Exterior];
                        LinkField Interiorlf = context.Fields[Templates._LinkItems.Fields.Interior];

                        //var backImg = (ImageField)item.Fields[Features.Templates.ImageItems.Fields.MobileImage];
                        if (Exteriorlf.TargetItem != null || Interiorlf.TargetItem != null)
                        {
                            if (Exteriorlf.TargetItem.HasChildren)
                            {
                                foreach (Item imageItem in Exteriorlf.TargetItem.GetChildren())
                                {

                                    var list = new Links
                                    {
                                        ExteriorLink = MediaManager.GetMediaUrl(imageItem)


                                    };
                                    linkList.Add(list);
                                }

                            }
                            if (Interiorlf.TargetItem.HasChildren)
                            {
                                foreach (Item imageItem in Interiorlf.TargetItem.GetChildren())
                                {
                                    var list = new Links
                                    {
                                        InteriorLink = MediaManager.GetMediaUrl(imageItem)
                                    };
                                    linkList.Add(list);
                                }
                            }
                            model.linkList = linkList;
                            //return View("~/Views/Gallery/InteriorExterior.cshtml", model);

                        }


                    }
                }
            
            
                if (!string.IsNullOrEmpty(DataSource))
                {
                    Item dataSource = Sitecore.Context.Database.GetItem(DataSource);
                    if (dataSource.TemplateID == Templates.GalleryHeaderItems.ID)
                    {
                        if (dataSource != null )
                        {
                            model.BlueTitle = !string.IsNullOrEmpty(dataSource.Fields[Templates.GalleryHeaderItems.Fields.BlueTitleGH].Value) ? dataSource.Fields[Templates.GalleryHeaderItems.Fields.BlueTitleGH].Value : string.Empty;
                            model.Title = !string.IsNullOrEmpty(dataSource.Fields[Templates.GalleryHeaderItems.Fields.TitleGH].Value) ? dataSource.Fields[Templates.GalleryHeaderItems.Fields.TitleGH].Value : string.Empty;
                            var image = (ImageField)dataSource.Fields[Templates.GalleryHeaderItems.Fields.IconImage];
                            model.IconImage = image != null && !string.IsNullOrEmpty(image.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(image.MediaItem)) ? MediaManager.GetMediaUrl(image.MediaItem) : string.Empty;
                            model.IconImageAlt = image.Alt != null && !string.IsNullOrEmpty(image.Alt) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(image.MediaItem)) ? image.Alt : string.Empty;
                            var BackImage = (ImageField)dataSource.Fields[Templates.GalleryHeaderItems.Fields.BackgroundImage];
                            model.BackgroundImg = BackImage != null && !string.IsNullOrEmpty(BackImage.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(BackImage.MediaItem)) ? MediaManager.GetMediaUrl(BackImage.MediaItem) : string.Empty;
                            model.BackGroundAlt = BackImage.Alt != null && !string.IsNullOrEmpty(BackImage.Alt) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(BackImage.MediaItem)) ? BackImage.Alt : string.Empty;
                            

                        }
                    }
                }
                return View("~/Views/Gallery/InteriorExterior.cshtml", model);
            }
            catch (Exception ex)
            {
                Log.Info("-----Error in Exterior and Interior Links --------", ex.Message);
            }
            return new EmptyResult();
        }
        public ActionResult CarDetail()
        {
            ImageAndVideoGallery CarDetail = new ImageAndVideoGallery();

            Item item = Sitecore.Context.Item;

            Sitecore.Data.Fields.ImageField HeaderImage = ((Sitecore.Data.Fields.ImageField)item.Fields["HeaderImage"]);
            CarDetail.HeaderImage = Sitecore.Resources.Media.MediaManager.GetMediaUrl(HeaderImage.MediaItem);

            Sitecore.Data.Fields.ImageField Image360degree = ((Sitecore.Data.Fields.ImageField)item.Fields["Image360degree"]);
            CarDetail.Image360degree = Sitecore.Resources.Media.MediaManager.GetMediaUrl(Image360degree.MediaItem);

            Sitecore.Data.Fields.ImageField MainImage = ((Sitecore.Data.Fields.ImageField)item.Fields["MainImage"]);
            CarDetail.MainImage = Sitecore.Resources.Media.MediaManager.GetMediaUrl(MainImage.MediaItem);
            CarDetail.DesignHeader = item.Fields["DesignHeader"].Value;
            CarDetail.DesignSubHeader = item.Fields["DesignSubHeader"].Value;
            CarDetail.VideoGalleryHeader = item.Fields["VideoGalleryHeader"].Value;
            CarDetail.VideoGallerySubHeader = item.Fields["VideoGallerySubHeader"].Value;
            CarDetail.ImageGalleryHeader = item.Fields["ImageGalleryHeader"].Value;
            CarDetail.ImageGallerySubHeader = item.Fields["ImageGallerySubHeader"].Value;

            var fieldItems = ((MultilistField)item.Fields[new Sitecore.Data.ID("{7D04740B-5747-4427-A21B-4B00F143B966}")]).GetItems();
            List<CarProperty> abc = new List<CarProperty>();
            foreach (var i in fieldItems)
            {
                try
                {
                    ImageField imageField = (ImageField)i.Fields["CarImage"];
                    CarProperty car = new CarProperty();
                    car.CarImage = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                    car.ImageName = i.Fields["ImageName"].Value;
                    string alt = imageField.Alt;
                    abc.Add(car);
                }
                catch (Exception ex)
                {

                    ex.ToString();
                }


            }
            CarDetail.CarImages = abc;

            var VideoImageItems = ((MultilistField)item.Fields[new Sitecore.Data.ID("{E0AB9C14-E6B2-4270-BD2C-3DD3D01C0435}")]).GetItems();
            List<string> VideoItems = new List<string>();
            foreach (var v in VideoImageItems)
            {
                try
                {
                    ImageField videoField = (ImageField)v.Fields["VideoImage"];
                    VideoItems.Add(Sitecore.Resources.Media.MediaManager.GetMediaUrl(videoField.MediaItem));
                    string alt = videoField.Alt;
                }
                catch (Exception ex)
                {

                    ex.ToString();
                }

            }
            CarDetail.VideoImage = VideoItems;

            var GalleryImageItems = ((MultilistField)item.Fields[new Sitecore.Data.ID("{BF0FEBB5-3F9A-4FD9-9A6A-76850C8E0DDC}")]).GetItems();
            List<string> galleryItems = new List<string>();
            foreach (var v in GalleryImageItems)
            {
                try
                {
                    ImageField ImageField = (ImageField)v.Fields["GalleryImage"];
                    galleryItems.Add(Sitecore.Resources.Media.MediaManager.GetMediaUrl(ImageField.MediaItem));
                    string alt = ImageField.Alt;
                }
                catch (Exception ex)
                {

                    ex.ToString();
                }

            }
            CarDetail.GalleryImage = galleryItems;

            return View("~/Views/Gallery/Gallery.cshtml",CarDetail);
        }
    }
}