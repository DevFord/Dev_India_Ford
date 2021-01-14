using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Features
{
    public struct Templates
    {
        public struct HeaderItems
        {
            public static readonly ID ID = new ID("{B2418257-CA45-4C40-BC90-BF2EDBB16F01}");
            public struct Fields
            {
                public static readonly ID BlueTitle = new ID("{A2D1DA6F-77E0-42D3-B327-8F9891636AD2}");
                public static readonly ID Title = new ID("{7EACF3BE-3EF8-4C13-987C-520954FC19D0}");
                //public static readonly ID IsFourthComponent = new ID("{99F9C943-5458-4898-9D80-CC0DB3F8CC10}");
                //public static readonly ID ImageList = new ID("{D4776845-07AF-42EC-B2F8-F9DACC5CDEA3}");
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