using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;

namespace FordIndia.Feature.Media.Models
{
    [SitecoreType(TemplateId = "{F0369E1A-9030-4A05-A09C-EF09B664ED27}")]
    public class ImageItem
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField(FieldId = "{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}")]
        public virtual string MediaTitle { get; set; }

        [SitecoreField(FieldId = "{302C9F8D-F703-4F76-A4AB-73D222648232}")]
        public virtual string MediaDescription { get; set; }

        [SitecoreField(FieldId = "{4FF62B0A-D73B-4436-BEA2-023154F2FFC4}")]
        public virtual Image MediaThumbnail { get; set; }

        [SitecoreField(FieldId = "{9F51DEAD-AD6E-41C2-9759-7BE17EB474A4}")]
        public virtual Image MediaImage { get; set; }
    }
}