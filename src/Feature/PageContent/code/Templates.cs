using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace FordIndia.Feature.PageContent
{
    public struct Templates
    {
        public struct PageContent
        {
            public static readonly ID ID = new ID("{05998E77-2E2A-41DB-ACA2-15D177D6F249}");
            public struct Fields
            {
                public static readonly ID HeaderTitle = new ID("{DFAB8AB5-1DAC-4191-A743-72E11C3E5970}");
                public static readonly ID HeaderDescription = new ID("{3BC1E7CB-19F0-40E0-A16D-D934AF20A42A}");
                public static readonly ID HeaderSummary = new ID("{2B322F9C-CBA5-408D-AEA2-E32D18FD53C2}");
                
            }
        }
        public struct PageContentImage
        {
            public static readonly ID ID = new ID("{05998E77-2E2A-41DB-ACA2-15D177D6F249}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{6889C45F-DD6E-45AB-A879-E0D01994FA3F}");
                public static readonly ID Description = new ID("{33C901A2-9F90-430D-8B3F-C1BC10992104}");
                public static readonly ID EmailImage = new ID("{64533A68-E7F1-4371-8A86-1BEA300BC00B}");
                public static readonly ID EmailDescription = new ID("{C40D3334-6B7E-461D-BBE8-E2926675E41D}");
                public static readonly ID SmsImage = new ID("{5AB580DA-06AA-4E5F-AFFF-129C54453106}");
                public static readonly ID SmsDescription = new ID("{BB74C06D-4781-4093-9745-9ACC70130560}");
                public static readonly ID TollFreeImage = new ID("{3D9039B2-E79D-402C-A82F-D6F4492DA73A}");
                public static readonly ID TollFreeDescription = new ID("{483E9B54-1129-4D29-AF82-512765502F98}");

            }
        }
        public struct InterestedSectionItem
        {
            public static readonly ID ID = new ID("{485208AB-55C9-45B5-B941-33967A160C51}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{B42CB8C5-C362-4528-A5C7-89AF4D5BD5F2}");
                public static readonly ID Description = new ID("{97D7BFD7-A110-4701-B033-178170519722}");
                public static readonly ID QuoteLink = new ID("{17041608-84E2-47D8-9C25-0D6618CF066B}");
                public static readonly ID Link = new ID("{2244B0F4-F214-4D83-859E-67DCD47D62DC}");
            }
        }
    }

}