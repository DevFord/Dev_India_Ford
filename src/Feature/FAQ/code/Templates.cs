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
                public static readonly ID FAQCategory = new ID("{DFC67494-C028-4CC3-9549-00156A7326A0}");
            }
        }
        public struct FAQCategoryItems
        {
            public static readonly ID ID = new ID("{86EEA8F7-4AF3-428E-977E-5D428109467F}");
            public struct Fields
            {
                public static readonly ID Name = new ID("{CEEEE0AC-FD52-4C3E-836D-C78854EEA741}");
                public static readonly ID Isparent = new ID("{6335079C-F44B-4D21-8A01-56E327B0A2F2}");
                
            }
        }

    }
    public class FolderID
    {
        public static readonly ID FAQFiltersID = new ID("{C852CB2E-6F79-4241-9FE4-8CA00C197F98}");
        public static readonly ID FAQID = new ID("{378D194F-8358-455B-93AA-6FFC7BCAD57D}");
    }
}