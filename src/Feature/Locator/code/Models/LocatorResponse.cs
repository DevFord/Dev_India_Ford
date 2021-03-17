using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FordIndia.Feature.Locator.Models;

namespace FordIndia.Feature.Locator.Models
{
    public class LocatorResponse
    {
       
            public string HasError { get; set; }
            public string MessageCode { get; set; }
            public string Message { get; set; }
            public List<LocatorData> Data { get; set; }
        
    }
    public class LocatorData
    {

        public Int64? DealerID { get; set; }
        public string DealerName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Locality { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostCode { get; set; }
        public string AdministrativeArea { get; set; }


    }



}