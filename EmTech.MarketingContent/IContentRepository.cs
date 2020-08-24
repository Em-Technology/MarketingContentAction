using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("EmtechActionsTests")]
namespace EmTech.MarketingContent
{
    internal interface IContentRepository
    {
        public Content GetNewPosts(ContentQuery query);
    }
}