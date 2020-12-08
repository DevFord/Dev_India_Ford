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
            public static ID LinkFieldID => new ID("{A68CA6C2-46BE-4FCF-A3F7-AA8A849AAE68}");
            public static ID MobileImage => new ID("{42284A58-25F9-47F7-A9DB-13826299EF07}");
            public static ID IsVideo => new ID("{83AAEDD3-19E3-4E0C-B2B3-FE0EF5A10412}");
            public static ID ButtonText => new ID("{0E39CF5F-7E4B-496E-A25D-DC47FBA2F6C2}");

        }
        public struct MediaGroup
        {
            public static readonly ID ID = new ID("{1361A3E5-D15E-43AB-8D0B-B02C3FB65AB2}");
        }
        public struct BannerBreadcrumb
        {
            public static readonly ID ID = new ID("{26812DC4-15C9-44F1-9A96-B991D95B099F}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{6673E33D-96B3-4F72-8316-08B11190AC8E}");
                public static readonly ID Image = new ID("{E4549837-B4FB-4845-9B49-1CB8A39FA13D}");
                public static readonly ID Link = new ID("{768D36DB-CB38-411C-8758-8EC19F2539D0}");
            }
        }
        public struct Banner
        {
            public static readonly ID ID = new ID("{75C60227-4DD3-40E1-91A2-80C7E734F92D}");
            public struct Fields
            {
                public static readonly ID BannerTitle = new ID("{FE06932D-75CD-400D-AD9B-45576DBCB922}");
                public static readonly ID BannerImage = new ID("{AAF04878-48DF-4C12-ADA5-2AD39C738729}");
                public static readonly ID CallToAction = new ID("{58B899F9-4BBC-4675-859A-3B35F828D415}");
            }
        }
        public struct _HasMediaVideoItem
        {
            public static readonly ID ID = new ID("{5A1B724B-B396-4C48-A833-655CD19018E1}");
            public struct Fields
            {
                public static readonly ID MediaVideoLink = new ID("{2628705D-9434-4448-978C-C3BF166FA1EB}");
            }
        }

    }
}