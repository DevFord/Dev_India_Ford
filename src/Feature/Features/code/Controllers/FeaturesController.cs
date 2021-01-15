using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FordIndia.Feature.Features.Models;
using System.Web.Mvc;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Resources.Media;

namespace FordIndia.Feature.Features.Controllers
{
    public class FeaturesController : Controller
    {
        // GET: Features
        public ActionResult ThreeFeature()
        {
            var model = new FeaturesDetails();
            var ImageListModel = new List<ImageDetails>();
            var Current = RenderingContext.CurrentOrNull.Rendering.DataSource;
            
            try
            {
                if (!string.IsNullOrEmpty(Current))
                {
                    Item dataSource = Sitecore.Context.Database.GetItem(Current);
                    if (dataSource.TemplateID == Templates.HeaderItems.ID)
                    {
                        if (dataSource != null && dataSource.GetChildren().Any() && dataSource.GetChildren() != null)
                        {
                            model.BlueTitle = !string.IsNullOrEmpty(dataSource.Fields[Templates.HeaderItems.Fields.BlueTitle].Value) ? dataSource.Fields[Templates.HeaderItems.Fields.BlueTitle].Value : string.Empty;
                            model.Title = !string.IsNullOrEmpty(dataSource.Fields[Templates.HeaderItems.Fields.Title].Value) ? dataSource.Fields[Templates.HeaderItems.Fields.Title].Value : string.Empty;
                            foreach (Item item in dataSource.GetChildren())
                            {
                                var image = (ImageField)item.Fields[Templates.ImageItems.Fields.Image];
                                var MobImage = (ImageField)item.Fields[Templates.ImageItems.Fields.MobileImage];
                                var imageDetails = new ImageDetails
                                {
                                    Heading = !string.IsNullOrEmpty(item.Fields[Templates.ImageItems.Fields.Heading].Value) ? item.Fields[Templates.ImageItems.Fields.Heading].Value : string.Empty,
                                    desc = !string.IsNullOrEmpty(item.Fields[Templates.ImageItems.Fields.Description].Value) ? item.Fields[Templates.ImageItems.Fields.Description].Value : string.Empty,
                                    Image = image != null && !string.IsNullOrEmpty(image.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(image.MediaItem)) ? MediaManager.GetMediaUrl(image.MediaItem) : string.Empty,
                                    MobileImg = MobImage != null && !string.IsNullOrEmpty(MobImage.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(MobImage.MediaItem)) ? MediaManager.GetMediaUrl(MobImage.MediaItem) : string.Empty
                                };
                                ImageListModel.Add(imageDetails);
                            }
                            model.ImageList = ImageListModel;
                            return View("~/Views/Features/ThreeFeatureComponent.cshtml", model);

                        }
                    }
                    
                    //else
                    //{
                    //    Item currentItem = Sitecore.Context.Item;
                    //    if (currentItem != null)
                    //    {
                    //        model.BlueTitle = !string.IsNullOrEmpty(currentItem.Fields[Templates.HeaderItems.Fields.BlueTitle].Value) ? currentItem.Fields[Templates.HeaderItems.Fields.BlueTitle].Value : string.Empty;
                    //        model.Title = !string.IsNullOrEmpty(currentItem.Fields[Templates.HeaderItems.Fields.Title].Value) ? currentItem.Fields[Templates.HeaderItems.Fields.Title].Value : string.Empty;
                    //        var checkbox = (CheckboxField)currentItem.Fields[Templates.HeaderItems.Fields.IsFourthComponent];
                    //        model.IsFourth = checkbox != null && checkbox.Checked ? true : false;
                    //        MultilistField multilist = currentItem.Fields[Templates.HeaderItems.Fields.ImageList];
                    //        Item[] items = multilist.GetItems();
                    //        var imageList = new List<ImageDetails>();
                    //        if (items != null)
                    //        {
                    //            foreach (Item item in items)
                    //            {
                    //                var image = (ImageField)item.Fields[Templates.ImageItems.Fields.Image];
                    //                var Mobileimage = (ImageField)item.Fields[Templates.ImageItems.Fields.MobileImage];
                    //                var imageDeatils = new ImageDetails
                    //                {
                    //                    Heading = !string.IsNullOrEmpty(item.Fields[Templates.ImageItems.Fields.Heading].Value) ? item.Fields[Templates.ImageItems.Fields.Heading].Value : string.Empty,
                    //                    desc = !string.IsNullOrEmpty(item.Fields[Templates.ImageItems.Fields.Description].Value) ? item.Fields[Templates.ImageItems.Fields.Description].Value : string.Empty,
                    //                    Image = image != null && !string.IsNullOrEmpty(image.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(image.MediaItem)) ? MediaManager.GetMediaUrl(image.MediaItem) : string.Empty,
                    //                    MobileImg = Mobileimage != null && !string.IsNullOrEmpty(image.Value) && !string.IsNullOrEmpty(MediaManager.GetMediaUrl(Mobileimage.MediaItem)) ? MediaManager.GetMediaUrl(Mobileimage.MediaItem) : string.Empty
                    //                };
                    //                imageList.Add(imageDeatils);
                    //            }
                    //            model.ImageList = imageList;
                    //            return View("~/Views/Features/ThreeFourComponent.cshtml", model);
                    //        }
                    //    }
                    //}
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