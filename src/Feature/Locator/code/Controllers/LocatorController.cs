using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.Locator;
using FordIndia.Feature.Locator.Models;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;

namespace FordIndia.Feature.Locator.Controllers
{
    public class LocatorController : Controller
    {

       
        // GET: Locator
        public ActionResult Index()
        {
            ApiCall apiCall = new ApiCall();
            var data = apiCall.CreateObject().Data;
            try
            {
                if (data != null)
                {
                    var item = data.Select(x => x.AdministrativeArea).Distinct();
                    ViewBag.State = item;
                    //var locality = BindCity(item.ToString());
                    var city = data.Select(x => x.Locality).Distinct();
                    ViewBag.City = city;
                    var dealer = data.Select(x => x.DealerName).Distinct();
                    ViewBag.Dealer = dealer;
                }
            }
            catch (Exception ex)
            {
                Log.Info("----------Not Working----------", ex.Message);
                return View("~/Views/Locator/Index.cshtml",data);
            }
            return View(data);

        }
        
        public JsonResult BindCity(string state)
        {
            ApiCall apiCall = new ApiCall();
            List<LocatorData> lstState = new List<LocatorData>();          
            var data = apiCall.CreateObject().Data;
            try
            {
                lstState = data.Where(a => a.AdministrativeArea == state).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return Json(lstState, JsonRequestBehavior.AllowGet);
        }
        public JsonResult BindDealer(string dealer)
        {
            ApiCall apiCall = new ApiCall();
            List<LocatorData> lstDealer = new List<LocatorData>();
            var data = apiCall.CreateObject().Data;
            try
            {
                lstDealer = data.Where(a => a.DealerName == dealer).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return Json(lstDealer, JsonRequestBehavior.AllowGet);
        }
        public JsonResult oldDealerLocator()
        {
            ApiCall apiCall = new ApiCall();
            List<LocatorData> lstlocation = new List<LocatorData>();
            var data = apiCall.CreateObject().Data;
            try
            {
                //lstDealer = data.Where(a => a.DealerName == dealer).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return Json(lstlocation, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult DealerLocator()
        {

            return PartialView("~/Views/Locator/DealerLocatorPV.cshtml");

        }

    }
}