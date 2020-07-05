using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("EmtechActionsTests")]
namespace MarketingContent
{
    internal sealed class MarkdownContentRepository : IContentRepository
    {
        private static readonly Lazy<IContentRepository> ContentRepository = 
            new Lazy<IContentRepository>(() => new MarkdownContentRepository());
        public static IContentRepository Repository => ContentRepository.Value;

        
        public Content GetNewPosts(ContentQuery query)
        {
            
           return new Content(); 
        }
    }
}