using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using FordIndia.Feature.Navigation.Models;

namespace FordIndia.Feature.Navigation.Repository
{
    public interface INavigationRepository
    {
        NavigationItems GetPrimaryMenu();
        NavigationItem GetSecondaryMenuItem();
        NavigationItems GetLinkMenuItems(Item menuItem);
    }
}
