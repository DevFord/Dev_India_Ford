using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.FAQ
{
    public struct Templates
    {
        public struct FAQ
        {
            public static readonly ID ID = new ID("{26CEDC58-293C-4474-A8DB-DE92464F2EBA}");
            public struct Fields
            {
                public static readonly ID Question = new ID("{01086A14-D804-4B10-9D5F-1D14174892AF}");
                public static readonly ID Answer = new ID("{037E34C4-F8A5-4118-B34E-46F75D975889}");
                public static readonly ID FAQFilter = new ID("{DFC67494-C028-4CC3-9549-00156A7326A0}");
            }
        }
        public struct FAQFilterItems
        {
            public static readonly ID ID = new ID("{86EEA8F7-4AF3-428E-977E-5D428109467F}");
            public struct Fields
            {
                public static readonly ID Name = new ID("{CEEEE0AC-FD52-4C3E-836D-C78854EEA741}");
                public static readonly ID Isparent = new ID("{6335079C-F44B-4D21-8A01-56E327B0A2F2}");
                public static readonly ID TabId = new ID("{D15929B6-0DDC-4750-8358-93F7F7A635A2}");
            }
        }
        public struct StyleItems
        {
            public static readonly ID ID = new ID("{B1DE4754-4368-439C-9C3A-9E42BEB1910F}");
            public struct Fields
            {
                public static readonly ID CollapseId = new ID("{8A3E2490-0A21-45D1-B931-B78A3AAD350D}");             
            }       
        }
    }
    public class FolderID
    {
        public static readonly ID FAQFiltersID = new ID("{C852CB2E-6F79-4241-9FE4-8CA00C197F98}");
        public static readonly ID FAQID = new ID("{378D194F-8358-455B-93AA-6FFC7BCAD57D}");
        public static readonly ID FAQsID = new ID("{C6777637-C769-4AE1-BE69-E91825CA4872}");
        public static readonly ID AccordianFolderID = new ID("{A4F1F3B0-2BE6-4C12-8CD9-572F7C0BB91C}");
        
    }
}
