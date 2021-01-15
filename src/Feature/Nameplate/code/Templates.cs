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
        public struct HeaderItems
        {
            public static readonly ID ID = new ID("{B2418257-CA45-4C40-BC90-BF2EDBB16F01}");
            public struct Fields
            {
                public static readonly ID BlueTitle = new ID("{A2D1DA6F-77E0-42D3-B327-8F9891636AD2}");
                public static readonly ID Title = new ID("{7EACF3BE-3EF8-4C13-987C-520954FC19D0}");
            }
        }
        public struct ImageItems
        {
            public static readonly ID ID = new ID("{FB927782-ECDB-4D55-8CC0-C6AA55D58E81}");
            public struct Fields
            {
                public static readonly ID Heading = new ID("{8564EE35-5AD3-4D3F-A4B7-CF03FBA894ED}");
                public static readonly ID Description = new ID("{EDC95F56-61D1-42AE-B8A0-42A24236F6B1}");
                public static readonly ID Image = new ID("{EDFCA2FD-FA94-43D7-AD22-80E38E40681B}");
                public static readonly ID MobileImage = new ID("{8377040C-EE92-4D25-96E9-12D1D0B2DBC7}");
            }
        }
    }
}