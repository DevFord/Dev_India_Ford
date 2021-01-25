using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Nameplate
{
    public class Templates
    {

        public struct _HasMediaImageItem
        {
            public static readonly ID ID = new ID("{FAE0C913-1600-4EBA-95A9-4D6FD7407E25}");
            public struct Fields
            {
                public static readonly ID MediaImage = new ID("{9F51DEAD-AD6E-41C2-9759-7BE17EB474A4}");
                public static readonly ID MobileImage = new ID("{42284A58-25F9-47F7-A9DB-13826299EF07}");
            }

        }
        public struct _HasMediaItem
        {
            public static readonly ID ID = new ID("{A44E450E-BA3F-4FAF-9C53-C63241CC34EB}");
            public struct Fields
            {
                public static readonly ID MediaTitle = new ID("{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}");
                public static readonly ID MediaDescription = new ID("{302C9F8D-F703-4F76-A4AB-73D222648232}");

            }

        }
        public struct LeftImageRightbullet
        {
            public static readonly ID ID = new ID("{24BEEA22-0B79-4620-A9E4-B811330B5D0F}");
            public struct Fields
            {
                public static readonly ID Header = new ID("{26248148-7B6B-4147-91CA-C93D439B6FF9}");
                public static readonly ID BlueTitle = new ID("{2DE1E7E7-C8FA-4B13-BAB3-E44843DC8565}");
                public static readonly ID RightBulletList = new ID("{11DC1F44-C6A8-44A0-8F62-D3E6F07583C4}");

            }

        }
        public struct TabAccordianHeaderItem
        {
            public static readonly ID ID = new ID("{E8C00375-D020-4604-AD99-8F64EFF75F04}");
            public struct Fields
            {
                public static readonly ID Title= new ID("{19ABED51-5423-40D2-9CC7-31A282A9A6A8}");
                public static readonly ID BlueTitle = new ID("{88E71010-D5B6-4292-B0EA-F8991DC24B56}");
                

            }
        }
        public struct _VerticalListingAccordianItems
        {
            public static readonly ID ID = new ID("{22AF0D1B-D7D3-4DCE-89D2-FE2C520BE4FE}");
            public struct Fields
            {
                public static readonly ID BlueTitle = new ID("{242F2EC8-E4FB-4826-8D4C-CDC28D72834C}");
                public static readonly ID Title = new ID("{4E0CEF4E-EC87-40D7-BCC5-A696B3CDCE3A}");
            }
        }

    }
}