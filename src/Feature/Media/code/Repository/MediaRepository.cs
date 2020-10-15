using FordIndia.Feature.Media.Models;
using FordIndia.Foundation.DependencyInjection;
using Glass.Mapper.Sc.Web.Mvc;
using System;

namespace FordIndia.Feature.Media.Repository
{
    [Service(Lifetime = Lifetime.Transient, ServiceType = typeof(IMediaRepository))]
    public class MediaRepository : IMediaRepository
    {
        public readonly IMvcContext _mvcContext;
        public MediaRepository(IMvcContext mvcContext)
        {
            this._mvcContext = mvcContext;
        }

        public Carousel GetCarouseItems()
        {
            try
            {
                var model = _mvcContext.GetDataSourceItem<Carousel>();
                return model;
            }
            catch (Exception ex)
            {
                Sitecore.Diagnostics.Log.Error(ex.Message, ex, this);
                return null;
            }
        }
    }
}