using FordIndia.Feature.Media.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}