using Glass.Mapper;
using Glass.Mapper.Caching;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using Glass.Mapper.Pipelines.ConfigurationResolver;
using Glass.Mapper.Pipelines.DataMapperResolver;
using Glass.Mapper.Pipelines.ObjectConstruction;
using Glass.Mapper.Pipelines.ObjectSaving;
using Glass.Mapper.Sc.DataMappers.SitecoreQueryParameters;
using Glass.Mapper.Sc.IoC;
using System;


namespace FordIndia.Foundation.DependencyInjection.App_Start
{
    public abstract class AbstractDependencyResolver : Glass.Mapper.IoC.IDependencyResolver
    {
        public CacheFactory CacheFactory { get; }
        public Config Config { get; set; }
        public ILog Log { get; set; }
        public Func<ICacheManager> CacheManager { get; set; }
        public IConfigFactory<AbstractDataMapperResolverTask> DataMapperResolverFactory { get; set; }
        public IConfigFactory<AbstractDataMapper> DataMapperFactory { get; set; }
        public IConfigFactory<AbstractConfigurationResolverTask> ConfigurationResolverFactory { get; set; }
        public IConfigFactory<AbstractObjectConstructionTask> ObjectConstructionFactory { get; set; }
        public IConfigFactory<AbstractObjectSavingTask> ObjectSavingFactory { get; set; }
        public IConfigFactory<ISitecoreQueryParameter> QueryParameterFactory { get; set; }
        public IGlassHtmlFactory GlassHtmlFactory { get; set; }
        public IConfigFactory<IGlassMap> ConfigurationMapFactory { get; set; }
        public LazyLoadingHelper LazyLoadingHelper { get; set; }

        public abstract ICacheManager GetCacheManager();


        public abstract Glass.Mapper.Config GetConfig();
        public abstract ILog GetLog();
    }
}