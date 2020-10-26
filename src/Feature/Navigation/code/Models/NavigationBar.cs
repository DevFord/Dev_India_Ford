using FordIndia.Foundation.SitecoreExtensions.Extensions;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Navigation.Models
{
    public class NavigationBar
    {
        public List<Item> NavbarItems { get; set; }
        public Item Logo { get; set; }
        public string LogoWhite { get; set; }

        public Item currentItem { get; set; }
        Database currentDB { get; set; }

        public NavigationBar()
        {
            currentItem = RenderingContext.Current.Rendering.Item;
            currentDB = Sitecore.Context.Database;

            Item navBarList = currentDB.GetItem(_Constants.NavigationListID);
            Logo = currentDB.GetItem(_Constants.LogoItemID);

            
            if (navBarList != null)
            {

                if (navBarList.Fields[Templates.NavigationListItem.ID.ToString()]?.Value != "")
                {
                    MultilistField navBarListField = navBarList.Fields[Templates.NavigationListItem.Fields.NavigationListItems.ToString()];
                    NavbarItems = navBarListField.GetItems().ToList();
                }
            }

        }
        public static List<Item> SubCategoryList()
        {
            
            List<Item> dropOuts = new List<Item>();

            Item parentItem = Sitecore.Context.Site.GetStartItem();
            dropOuts = parentItem.Axes.GetDescendants().Where(x => x.TemplateID.Equals(_Constants.SubCategorylanding)).ToList();
            
            return dropOuts;
        }
    }
}