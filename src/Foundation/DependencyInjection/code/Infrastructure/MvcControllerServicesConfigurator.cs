namespace Sitecore.Foundation.DependencyInjection.Infrastructure
{
    using System.Reflection;
    using System.Web.Mvc;
    using Fortis.Model;
    using Fortis.Mvc.Providers;
    using Fortis.Providers;
    using Fortis.Search;
    using Microsoft.Extensions.DependencyInjection;
    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using Sitecore.DependencyInjection;

    public class MvcControllerServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("*.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("*.Foundation.*");

            var container = new Container();
            // Fortis
            container.Register<IContextProvider, ContextProvider>(Lifestyle.Singleton);
            container.Register<ISpawnProvider, SpawnProvider>(Lifestyle.Singleton);
            container.Register<IModelAssemblyProvider, ModelAssemblyProvider>(Lifestyle.Singleton);
            container.Register<ITemplateMapProvider, TemplateMapProvider>(Lifestyle.Singleton);
            container.Register<ISearchResultsAdapter, SearchResultsAdapter>(Lifestyle.Singleton);
            container.Register<IItemFactory, ItemFactory>(Lifestyle.Singleton);
            container.Register<IItemSearchFactory, ItemSearchFactory>(Lifestyle.Singleton);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            Fortis.Global.Initialise(
                spawnProvider: DependencyResolver.Current.GetService<ISpawnProvider>(),
                itemFactory: DependencyResolver.Current.GetService<IItemFactory>(),
                itemSearchFactory: DependencyResolver.Current.GetService<IItemSearchFactory>());
        }
    }
}