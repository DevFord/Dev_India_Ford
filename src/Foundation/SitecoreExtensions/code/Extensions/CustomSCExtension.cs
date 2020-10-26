using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;

namespace FordIndia.Foundation.SitecoreExtensions.Extensions
{
    public class CustomSCExtension
    {
        public static string GetImageURL(ImageField field)
        {
            string imageURL = string.Empty;
            if (field != null && field.MediaItem != null)
            {
                Sitecore.Data.Items.MediaItem image = new Sitecore.Data.Items.MediaItem(field.MediaItem);
                imageURL = Sitecore.Resources.Media.MediaManager.GetMediaUrl(image);
            }
            return imageURL;
        }
        public static string LinkUrl(LinkField linkField)
        {
            if (linkField != null)
            {
                switch (linkField.LinkType.ToLower())
                {
                    case "internal":
                        // Use LinkMananger for internal links, if link is not empty
                        return linkField.TargetItem != null ? Sitecore.Links.LinkManager.GetItemUrl(linkField.TargetItem) : string.Empty;
                    case "media":
                        // Use MediaManager for media links, if link is not empty
                        return linkField.TargetItem != null ? Sitecore.Resources.Media.MediaManager.GetMediaUrl(linkField.TargetItem) : string.Empty;
                    case "external":
                        // Just return external links
                        return linkField.Url;
                    case "anchor":
                        // Prefix anchor link with # if link if not empty
                        return !string.IsNullOrEmpty(linkField.Anchor) ? "#" + linkField.Anchor : string.Empty;
                    case "mailto":
                        // Just return mailto link
                        return linkField.Url;
                    case "javascript":
                        // Just return javascript
                        return linkField.Url;
                    default:
                        // Just please the compiler, this
                        // condition will never be met
                        return linkField.Url;
                }
            }
            return "";
        }
    }
}