using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("EmtechActionsTests")]
namespace MarketingContent
{
    internal interface IContentRepository
    {
        public Content GetNewPosts(ContentQuery query);
    }
}