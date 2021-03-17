using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Gallery
{
    public class Templates
    {
        public struct _LinkItems
        {
            public static readonly ID ID = new ID("{F9BC6571-C7C4-4213-9194-2663BEE7F5F1}");
            public struct Fields
            {
                public static readonly ID Interior = new ID("{CB8BD654-6084-4427-9EDB-FB4E19C0883C}");
                public static readonly ID Exterior = new ID("{AF57FDB0-8F88-4017-BCE5-A776F9EA9D8A}");

            }

        }
        public struct GalleryHeaderItems
        {
            public static readonly ID ID = new ID("{931B504F-2D4D-4A01-ACD7-BD9E4BAF9004}");
            public struct Fields
            {
                public static readonly ID BlueTitleGH = new ID("{030E1A8D-7495-4814-B213-A2E220C474DB}");
                public static readonly ID TitleGH = new ID("{E8ABBDA4-C430-470C-8DA7-C69289FEF543}");
                public static readonly ID IconImage = new ID("{FB1D7062-BECD-4EA9-A44C-1FF46E2B8D3B}");
                public static readonly ID BackgroundImage = new ID("{7B41772D-812E-4994-95BD-87C572B70357}");

            }

        }
        public struct ImageHeaderItems
        {
            public static readonly ID ID = new ID("{0CE243FD-1353-41D3-9630-A73A6DB21E0F}");
            public struct Fields
            {
                public static readonly ID Header = new ID("{E58A348C-B1A0-418C-AD6E-8DD3BDE988AD}");
            }
        }
        public struct ImageItems
        {
            public static readonly ID ID = new ID("{FA91CA76-AA65-4B5F-9A5E-8438177BDE0A}");
            public struct Fields
            {
                public static readonly ID Image = new ID("{8665710E-A819-42FF-9A3A-3A14C0886610}");
               
            }
        }
        public struct VideoHeaderItems
        {
            public static readonly ID ID = new ID("{CE1879F4-6862-4E33-8EC8-C997FD9F6037}");
            public struct Fields
            {
                public static readonly ID Header = new ID("{D12DD67C-EDC0-4270-ABB0-30FBBBBFC9B8}");
                public static readonly ID Link = new ID("{1253C598-522C-4D4F-A408-4372FC430443}");

            }

        }
        public struct VideoItems
        {
            public static readonly ID ID = new ID("{CA9B9904-917C-477E-B792-9D735953584E}");
            public struct Fields
            {
                public static readonly ID Video = new ID("{3F30996D-E8F0-430D-A98D-7B38221F2BE8}");
                

            }

        }

    }
}
