using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Locator
{
    public class Templates
    {
        public struct LocaterItem
        {
            public static readonly ID ID = new ID("{FEEE01BD-4CE7-4BA2-AF8F-1C9E91CEF182}");
            public struct Fields
            {
                public static readonly ID Header = new ID("{605A1EB1-34BA-4D8A-A8CA-1EE6940FB665}");
                public static readonly ID Image = new ID("{97DB06A0-2255-42A6-9855-D10071127B47}");

            }

        }
    }
}