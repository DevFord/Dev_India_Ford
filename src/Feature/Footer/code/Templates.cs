using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Footer
{
    public struct Templates
    {
        public struct FooterHeaderItem
        {
            public static readonly ID ID = new ID("{26D11C32-FCA0-40A1-BC1D-A77ED224C910}");
            public struct Fields
            {
                public static readonly ID FooterHeaderTitle = new ID("{382DA7C8-EC60-4516-A4A1-4CE323CF11CD}");
                public static readonly ID FooterHeaderLink = new ID("{5C635287-792A-4D93-80F1-28B90E7EF8A0}");
                public static readonly ID FooterIcon = new ID("{3E2ACC78-5ED3-43CA-9442-22E0B3CB4113}");                
                public static readonly ID IsMenu = new ID("{0E80ACD1-2356-4FB8-B77F-C33EF74D0F30}");
            }
        }
        public struct FooterLinksItem
        {
            public static readonly ID ID = new ID("{33B41029-6AD4-4F5C-AF68-97F343B8EDE0}");
            public struct Fields
            {
                public static readonly ID FooterTitle = new ID("{6BE6A780-AC62-454A-8700-75B0508E594E}");
                public static readonly ID FooterLink = new ID("{66E6C41A-B190-48A9-8FF4-C100F667EC1E}");
               
            }
        }
        public struct SocialItems
        {
            public static readonly ID ID = new ID("{F5FA406E-51C4-4A15-B0BF-5BA2595FB7AA}");
            public struct Fields
            {
                public static readonly ID SocialTitle = new ID("{A2899B90-F851-4558-AE6E-DF4409F53259}");
                public static readonly ID SocialLink = new ID("{E663822F-B878-4D74-84E0-9C886F63B7E5}");
                public static readonly ID SocialClass = new ID("{41C5EE14-3C80-4278-92BD-EDD32BC037D4}");

            }
        }
        public struct LogoItem
        {
            public static readonly ID ID = new ID("{0378B953-91C5-4240-80BA-47D3FBCD52DE}");
            public struct Fields
            {
                public static readonly ID Logo = new ID("{EBB088E0-138C-4B05-9F5C-588BE2378D99}");
                public static readonly ID Link = new ID("{BFEB3B64-97B3-40C8-B727-BFE5BE004591}");
                public static readonly ID LogoWhite = new ID("{5C61B62E-53F1-49AD-BD00-1AD9FD890454}");

            }

        }

    }
    public class FolderID
    {
        public static readonly ID FooterFolderID = new ID("{94FB6BA5-269D-4806-BE57-E8DC31DC6B65}");
        public static readonly ID SocialFolderID = new ID("{9D8F90FD-8EB1-494E-B7AE-13C3C9DC9303}");
        public static readonly ID AdditionalFolderID = new ID("{A06D4B68-8E9E-40E4-A114-E3B3DB17EC32}");
        //public static readonly ID LogoItemID = new ID("{AA7ED8D8-E1C3-4664-BFF8-162A3E3375FF}");
    }
}