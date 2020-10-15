using Sitecore;
using Sitecore.Abstractions;
using Sitecore.Configuration;
using Sitecore.Web;
using System.Web;

namespace FordIndia.Foundation.ErrorHandling.Pipelines.HttpRequestBegin
{
    public class ExecuteRequest : global::Sitecore.Pipelines.HttpRequest.ExecuteRequest
    {
        private readonly BaseLinkManager _baseLinkManager;

        public ExecuteRequest(BaseSiteManager baseSiteManager, BaseItemManager baseItemManager, BaseLinkManager baseLinkManager) : base(baseSiteManager, baseItemManager)
        {
            _baseLinkManager = baseLinkManager;
        }

        protected override void PerformRedirect(string url)
        {
            if (Context.Site == null || Context.Database == null || Context.Database.Name == "core")
            {
                return;
            }

            // need to retrieve not found item to account for sites utilizing virtualFolder attribute
            var notFoundItem = Context.Database.GetItem(Context.Site.StartPath + Settings.ItemNotFoundUrl);

            if (notFoundItem == null)
            {
                return;
            }

            var notFoundUrl = _baseLinkManager.GetItemUrl(notFoundItem);

            if (string.IsNullOrWhiteSpace(notFoundUrl))
            {
                return;
            }


            if (Settings.RequestErrors.UseServerSideRedirect)
            {
                HttpContext.Current.Server.TransferRequest(notFoundUrl);
            }
            else
                WebUtil.Redirect(notFoundUrl, false);
        }
    }
}