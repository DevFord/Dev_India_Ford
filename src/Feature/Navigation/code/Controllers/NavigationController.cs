using FordIndia.Feature.Navigation.Repository;
using FordIndia.Foundation.Dictionary.Repositories;
using Sitecore;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FordIndia.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        private readonly INavigationRepository navigationRepository;

        public NavigationController(INavigationRepository navigationRepository)
        {
            this.navigationRepository = navigationRepository;
        }

        //public ActionResult Breadcrumb()
        //{
        //    var items = this.navigationRepository.GetBreadcrumb();
        //    return this.View("Breadcrumb", items);
        //}

        public ActionResult PrimaryMenu()
        {
            var items = this.navigationRepository.GetPrimaryMenu();
            return this.View("PrimaryMenu", items);
        }

        public ActionResult SecondaryMenu()
        {
            var item = this.navigationRepository.GetSecondaryMenuItem();
            return this.View("SecondaryMenu", item);
        }

        public ActionResult NavigationLinks()
        {
            if (string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                return null;
            }
            var item = RenderingContext.Current.Rendering.Item;
            var items = this.navigationRepository.GetLinkMenuItems(item);
            return this.View(items);
        }

        public ActionResult LinkMenu()
        {
            if (string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                return null;
            }
            var item = RenderingContext.Current.Rendering.Item;
            var items = this.navigationRepository.GetLinkMenuItems(item);
            return this.View("LinkMenu", items);
        }
    }
}