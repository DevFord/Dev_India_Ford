using System;
using System.Net;
using System.Web;
using Sitecore.Configuration;
using Sitecore.Pipelines.HttpRequest;

namespace FordIndia.Foundation.ErrorHandling.Pipelines.HttpRequestEnd
{
    public class Set404StatusCode : HttpRequestBase
    {
        protected override void Execute(HttpRequestArgs args)
        {
            // retain 500 response if previously set
            if (HttpContext.Current.Response.StatusCode >= 500 || args.HttpContext.Request.RawUrl == "/" || Sitecore.Context.Site == null)
                return;

            // return if request does not end with value set in ItemNotFoundUrl, i.e. successful page
            if (!args.HttpContext.Request.Url.LocalPath.EndsWith(Settings.ItemNotFoundUrl, StringComparison.InvariantCultureIgnoreCase))
                return;
            HttpContext.Current.Response.TrySkipIisCustomErrors = true;
            HttpContext.Current.Response.StatusCode = (int)HttpStatusCode.NotFound;
            HttpContext.Current.Response.StatusDescription = "Page not found";
        }
    }
}