using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;

namespace FordIndia.Feature.Media.Models
{
    [SitecoreType(TemplateId = "{C18D3794-D126-4548-BFC8-89358DE6E9C1}")]
    public class Carousel
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField(FieldId = "{72EA8682-24D2-4BEB-951C-3E2164974105}")]
        public virtual IEnumerable<ImageItem> CarouseImage { get; set; }
    }
}