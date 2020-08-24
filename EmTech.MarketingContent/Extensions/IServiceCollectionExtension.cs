using Microsoft.Extensions.DependencyInjection;

namespace EmTech.MarketingContent.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddMarketingManagement(this IServiceCollection services)
        {
            services.AddTransient<ContentLoader>(_ => ContentLoaderFactory.AddContentLoader(ContentSource.Markdown));
            return services;
        }
    }
}