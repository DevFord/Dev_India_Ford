using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;
using FordIndia.Feature.Locator.App_Start;

namespace FordIndia.Feature.Locator.Pipelines
{
    public class RegisterRoutes
    {
        public void Process(PipelineArgs args)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
} 