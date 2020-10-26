using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FordIndia.Feature.Navigation
{
    public class Templates
    {
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
        public struct NavigationListItem
        {
            public static readonly ID ID = new ID("{4C5753EB-F68B-4521-AC59-E2D8541AC96A}");
            public struct Fields
            {
                public static readonly ID NavigationListItems = new ID("{CC6CEAB5-4826-4F6B-8F8A-61BD72F31C72}");
            }
        }
        public struct Navigable
        {
            public static readonly ID ID = new ID("{A1CBA309-D22B-46D5-80F8-2972C185363F}");
            public struct Fields
            {
                public static readonly ID NavigationTitle = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public static readonly ID ShowInNavigation = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public static readonly ID ShowChildren = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                //public static readonly ID SubCatList = new ID("{C75E333D-0E73-45C8-B931-CB83D163B3CF}");
            }
        }
        public struct RightNavigation
        {
            public static readonly ID ID = new ID("{8BDF61D7-AD10-4823-B65F-08B8351A9718}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{50345B7D-E0E1-4CFB-816B-A09144FB762E}");
                public static readonly ID Link = new ID("{B0A7A4CA-83DE-491B-8A46-1C221C45DAE2}");
                public static readonly ID Icon = new ID("{75AAA41F-ACF1-451E-B6D9-387239D86DC8}");
                public static readonly ID MobileIcon = new ID("{9E672D7B-EF57-4C77-894E-98D53354D98B}");
            }

        }
        public struct Subcategory
        {
            public static readonly ID ID = new ID("{9F7E74F8-1302-4EF6-9D93-16A5279587CE}");
            public struct Fields
            {
                public static readonly ID SubCategoryName = new ID("{1982A9AD-C6F1-4BC7-8106-C343A9066ACB}");
                public static readonly ID SubCatDescription = new ID("{3613AB18-178D-4698-B1AD-49FF73767036}");
                public static readonly ID SubCategoryThumbnail = new ID("{3B91895F-1219-4936-A0FB-79CB348B69A9}");
                public static readonly ID SeatingText = new ID("{5D1EDEE5-4F33-45AB-AC74-FBA22CBF57B0}");
                public static readonly ID SeatingCount = new ID("{14B84EC9-2B90-4DBB-98F8-B0EF51845E65}");
                public static readonly ID PriceText = new ID("{91E3213E-1FB1-4A60-9A9B-931F5041ADE1}");
                public static readonly ID Price = new ID("{09E7CAE7-4983-4DE4-980A-076F5909B480}");
                public static readonly ID MPGText = new ID("{653C4419-E323-4FEF-9CC1-D585C8B65B8B}");
                public static readonly ID MPGValue = new ID("{F914DA57-DFB8-4F62-9F77-13C492D0041C}");

            }
        }
        public struct NavigationRoot
        {
            public static readonly ID ID = new ID("{F9F4FC05-98D0-4C62-860F-F08AE7F0EE25}");
        }
        public struct Link
        {
            public static readonly ID ID = new ID("{A16B74E9-01B8-439C-B44E-42B3FB2EE14B}");

            public struct Fields
            {
                public static readonly ID Link = new ID("{FE71C30E-F07D-4052-8594-C3028CD76E1F}");
            }
        }
    }
}