namespace MarketingContent
{
    internal interface IContentRepository
    {
        public Content GetNewPosts(ContentQuery query);
    }
}