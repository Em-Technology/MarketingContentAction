using EmTech.MarketingContent.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmTech.Actions.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddAction(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMarketingManagement();
            return services;
         } 
    }
}