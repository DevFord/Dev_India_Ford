using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using Sitecore.Data;
using FordIndia.Feature.Footer;
using System.Linq;

namespace FordIndia.Feature.Footer.Models
{
    public class Footer
    {
        public List<FooterItem> FooterItems;
        public List<Item> SocialItems;
        public List<Item> AdditionalFooterItems { get; set; }


        public Footer()
        {
            Database cuurentDB = Sitecore.Context.Database;
            Item FoooterFolderId = cuurentDB.GetItem(FolderID.FooterFolderID);
            Item SocialFolderId = cuurentDB.GetItem(FolderID.SocialFolderID);
            Item AddFolderId = cuurentDB.GetItem(FolderID.AdditionalFolderID);

            FooterItems = new List<FooterItem>();
            if (FoooterFolderId != null)
            {
                List<Item> headerItems = getFooterHeader(FoooterFolderId);
                if (headerItems != null)
                {
                    foreach (Item headerItem in headerItems)
                    {
                        FooterItem footItem = new FooterItem();
                        footItem.FooterHeader = headerItem;
                        footItem.FooterLinks = getFooterLink(headerItem);
                        FooterItems.Add(footItem);
                    }
                }
                if (SocialFolderId != null && SocialFolderId.HasChildren)
                {
                    SocialItems = getSocialItems(SocialFolderId);
                }
                if (AddFolderId != null && AddFolderId.HasChildren)
                {
                    AdditionalFooterItems = getAdditionalLink(AddFolderId);
                }
            }

        }
        public List<Item> getFooterHeader(Item folder)
        {
            List<Item> children = folder.GetChildren().Where(x => x.TemplateID.Equals(Templates.FooterHeaderItem.ID)).ToList();
            return children;
        }
        public List<Item> getFooterLink(Item headitem)
        {
            List<Item> children = headitem.GetChildren().Where(x => x.TemplateID.Equals(Templates.FooterLinksItem.ID)).ToList();
            return children;
        }
        public List<Item> getSocialItems(Item socialFolder)
        {
            List<Item> children = socialFolder.GetChildren().Where(x => x.TemplateID.Equals(Templates.SocialItems.ID)).ToList();
            return children;
        }
        public List<Item> getAdditionalLink(Item additem)
        {
            List<Item> children = additem.GetChildren().Where(x => x.TemplateID.Equals(Templates.FooterLinksItem.ID)).ToList();
            return children;
        }
    }
}