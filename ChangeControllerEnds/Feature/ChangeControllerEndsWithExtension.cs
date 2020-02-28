using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ChangeControllerEnds.Feature
{
    public static class ChangeControllerEndsWithExtension
    {
        public static void AddChangeControllerEndWith(this IServiceCollection services, string controllerEndwith)
        {
            services.TryAddEnumerable(
                 ServiceDescriptor.Transient<IApplicationModelProvider, KishanApplicationModelProvider>
                            (factory => new KishanApplicationModelProvider(controllerEndwith)));
        }

        public static IMvcBuilder AddControllerFeatureProvider(this IMvcBuilder builder, string controllerEndwith)
           => builder.ConfigureApplicationPartManager(partManager
                => partManager.FeatureProviders.Add(new KishanControllerFeatureProvider(controllerEndwith)));
    }
}