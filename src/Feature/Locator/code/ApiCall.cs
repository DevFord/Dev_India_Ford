using RestSharp;
using System;
using FordIndia.Feature.Locator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace FordIndia.Feature.Locator
{
    public class ApiCall
    {
        private const string URL = "http://52.172.162.114:8080/api/DealerShip/GetDealersData";
        LocatorInput inputModel = new LocatorInput();
        //List<LocatorInput >inputModel = new List<LocatorInput>();
        public LocatorResponse CreateObject()
        {

            LocatorResponse locatoResponse = new LocatorResponse();
            try
            {
                RestClient restClient = new RestClient(URL);
                RestRequest request = new RestRequest(Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(inputModel);
                var response = restClient.Execute<LocatorInput>(request);
                if ( response.IsSuccessful)
                {
                    locatoResponse = JsonConvert.DeserializeObject<LocatorResponse>(response.Content);
                }
                return locatoResponse;
            }
            catch(Exception ex) {
                Sitecore.Diagnostics.Log.Info("Error",ex.Message);
                
            }

            return null;

        }
    }
}