using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.Locator;
using FordIndia.Feature.Locator.Models;



namespace FordIndia.Feature.Locator.Controllers
{
    public class LocatorController : Controller
    {

        ApiCall apiCall = new ApiCall();
        // GET: Locator
        public ActionResult Index()
        {
           
            var data = apiCall.CreateObject().Data;
            var item = data.Select(x => x.AdministrativeArea).Distinct();
            ViewBag.State = item;
            //var locality = BindCity(item.ToString());
            var city= data.Select(x => x.Locality).Distinct();
            ViewBag.City = city;
            var dealer = data.Select(x => x.DealerName).Distinct();
            ViewBag.Dealer = dealer;
            return View(data);

        }
        
        public JsonResult BindCity(string state)
        {

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

            List<LocatorData> lstState = new List<LocatorData>();
            var data = apiCall.CreateObject().Data;
            try
            {
                lstState = data.Where(a => a.DealerName == dealer).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return Json(lstState, JsonRequestBehavior.AllowGet);
        }

    }
}