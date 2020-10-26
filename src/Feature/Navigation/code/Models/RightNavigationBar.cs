using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Navigation.Models
{
    public class RightNavigationBar
    {
       public List<Item> RightNavItems { get; set; }
        public RightNavigationBar()
        {

            Database currentDB = Sitecore.Context.Database;
            Item RightNavigationFolder = currentDB.GetItem(_Constants.RightNavigationListID);


            if (RightNavigationFolder != null && RightNavigationFolder.HasChildren)
            {
                RightNavItems = RightNavigationFolder.GetChildren().ToList();
            }
        }
    }
}