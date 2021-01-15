using FordIndia.Feature.Navigation.Repository;
using FordIndia.Foundation.Dictionary.Repositories;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FordIndia.Feature.Navigation.Models;
using Sitecore.Data.Fields;
using Sitecore.Diagnostics;
using FordIndia.Foundation.SitecoreExtensions.Extensions;


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
        public ActionResult BreadcrumbNav()
        {
            var breadCrumbNav = new BreadcrumbNav();
            var breadcrumbsNav = new List<BreadcrumbNav>();
            var breadcrumbchild = new List<BreadcrumbchildNav>();
            try
            {
                var ds = RenderingContext.CurrentOrNull.Rendering.DataSource;
                if (!string.IsNullOrEmpty(ds))
                {
                    Item breadNav = Sitecore.Context.Database.GetItem(ds);
                    if (breadNav.TemplateID == Templates.Navigable.ID)
                    {
                        if (breadNav != null && breadNav.GetChildren() != null && breadNav.GetChildren().Any())
                        {
                            foreach (Item item in breadNav.GetChildren())
                            {
                                var showMenu = (CheckboxField)item.Fields[Templates.Navigable.Fields.ShowInNavigation];
                                var showChildMenu = (CheckboxField)item.Fields[Templates.Navigable.Fields.ShowChildren];
                                if (showChildMenu.Checked && showMenu.Checked && item.Children.InnerChildren.Count > 0)
                                {
                                    foreach (var items in item.Children.InnerChildren)
                                    {
                                        var Navitem = new BreadcrumbchildNav
                                        {
                                            childTitleName = !string.IsNullOrEmpty(items.Fields[Templates.Navigable.Fields.NavigationTitle].Value) ? items.Fields[Templates.Navigable.Fields.NavigationTitle].Value : string.Empty,
                                            childLink = !string.IsNullOrEmpty(CustomSCExtension.LinkUrl(items.Fields[Templates.Link.Fields.Link])) ? CustomSCExtension.LinkUrl(items.Fields[Templates.Link.Fields.Link]) : string.Empty
                                        };
                                        breadcrumbchild.Add(Navitem);
                                    }
                                    breadCrumbNav.navchildItems = breadcrumbchild;
                                }
                                var breadNavitem = new BreadcrumbNav
                                {
                                    TitleName = !string.IsNullOrEmpty(item.Fields[Templates.Navigable.Fields.NavigationTitle].Value) ? item.Fields[Templates.Navigable.Fields.NavigationTitle].Value : string.Empty,
                                    ShowMenu = showMenu.Checked ? true : false,
                                    ShowChildren = showChildMenu.Checked ? true : false,
                                    Link = !string.IsNullOrEmpty(CustomSCExtension.LinkUrl(item.Fields[Templates.Link.Fields.Link])) ? CustomSCExtension.LinkUrl(item.Fields[Templates.Link.Fields.Link]) : string.Empty
                                };
                                breadcrumbsNav.Add(breadNavitem);
                                breadCrumbNav.navItems = breadcrumbsNav;
                            }
                           
                            return View("~/Views/Navigation/BreadcrumbNavigation.cshtml", breadCrumbNav);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Info("-----BreadcrumbNav----", ex);
            }
            return new EmptyResult();
        }
        public ActionResult ScrollNav()
        {
            var model = new List<ScrollNav>();          
            var Current = RenderingContext.CurrentOrNull.Rendering.DataSource;
            try
            {
                if (!string.IsNullOrEmpty(Current))
                {
                    Item dataSource = Sitecore.Context.Database.GetItem(Current);
                    if (dataSource != null && dataSource.GetChildren().Any() && dataSource.GetChildren() != null)
                    {
                        foreach (Item item in dataSource.GetChildren())
                        {
                            var scrollnav = new ScrollNav {
                                Title=!string.IsNullOrEmpty(item.Fields[Templates.ScrollNavItems.Fields.Title].Value)? item.Fields[Templates.ScrollNavItems.Fields.Title].Value:string.Empty,
                                Link = !string.IsNullOrEmpty(item.Fields[Templates.ScrollNavItems.Fields.LinkID].Value)? item.Fields[Templates.ScrollNavItems.Fields.LinkID].Value : string.Empty
                            };
                            model.Add(scrollnav);
                        }
                        return View("~/Views/Navigation/ScrollNavigation.cshtml", model);
                    }

                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return new EmptyResult();

        }
    }
}