using Sitecore.Data;

namespace FordIndia.Feature.Media
{
    public class Templates
    {
        public struct Carousel
        {
            public static ID CarouselTemplateID => new ID("{C18D3794-D126-4548-BFC8-89358DE6E9C1}");

            public static ID MediaSelectorFieldID => new ID("{72EA8682-24D2-4BEB-951C-3E2164974105}");
        }

        public struct ImageItem
        {
            public static ID ImageItemTemplateID => new ID("{F0369E1A-9030-4A05-A09C-EF09B664ED27}");

            public static ID MediaTitleFieldID => new ID("{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}");

            public static ID MediaDescriptionFieldID => new ID("{302C9F8D-F703-4F76-A4AB-73D222648232}");

            public static ID MediaThumbnailFieldID => new ID("{4FF62B0A-D73B-4436-BEA2-023154F2FFC4}");

            public static ID MediaImageFieldID => new ID("{9F51DEAD-AD6E-41C2-9759-7BE17EB474A4}");
        }
    }
}